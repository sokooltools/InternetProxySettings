using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using InternetProxySettings.Properties;
using Microsoft.Win32;

namespace InternetProxySettings
{
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Provides internet settings information.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public class InternetSettings
	{
		private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
		private const int INTERNET_OPTION_REFRESH = 37;

		//.................................................................................................................................

		#region Public Constructors

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Initializes a new instance of the <see cref="InternetSettings"/> class using the values currently stored in the
		/// registry as the defaults.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		public InternetSettings()
		{
			Reset(true);
			LoadProperties();
		}

		#endregion

		//.................................................................................................................................

		#region Private Fields

		private string _proxyHost;
		private int _proxyPort;

		#endregion

		//.................................................................................................................................

		#region Public Properties & Methods

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets or sets a value indicating whether the proxy server is used for the LAN.
		/// </summary>
		/// <value><c>true</c> if this instance is enabled; otherwise, <c>false</c>.</value>
		//------------------------------------------------------------------------------------------------------------------------
		public bool IsEnabled { get; set; }

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets or sets a value indicating whether the proxy server is bypassed for local addresses.
		/// </summary>
		/// <value><c>true</c> if the proxy server is bypassed for local addresses; otherwise, <c>false</c>.</value>
		//------------------------------------------------------------------------------------------------------------------------
		public bool IsLocalBypassed { get; set; }

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets or sets the proxy host.
		/// </summary>
		/// <value>The proxy host.</value>
		//------------------------------------------------------------------------------------------------------------------------
		public string ProxyHost
		{
			get { return _proxyHost; }
			set
			{
				if (value != null && value.StartsWith("http"))
					value = value.Substring(5);

				if (!IsValidHostName(value))
					throw new InvalidPropertyValueException(value);

				_proxyHost = value == null ? null : value.Trim();
			}
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets or sets the proxy port.
		/// </summary>
		/// <value>The proxy port.</value>
		/// <exception cref="InvalidPropertyValueException">
		/// Value must either be a 0 or a number between 2 and 5 digits.
		/// </exception>
		//------------------------------------------------------------------------------------------------------------------------
		public int ProxyPort
		{
			get { return _proxyPort; }
			set
			{
				if (!IsValidProxyPort(value))
					throw new InvalidPropertyValueException(value);
				_proxyPort = value;
			}
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Gets or sets the proxy override.
		/// </summary>
		/// <value>The proxy override.</value>
		//------------------------------------------------------------------------------------------------------------------------
		public string ProxyOverride { get; set; }

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Returns a <see cref="System.String"/> that represents this instance.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents this instance.</returns>
		//------------------------------------------------------------------------------------------------------------------------
		public override string ToString()
		{
			return String.IsNullOrEmpty(ProxyHost) || ProxyPort == 0 ? "" : "http://" + ProxyHost + ":" + ProxyPort;
		}

		#endregion

		//.................................................................................................................................

		#region Public Methods

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Saves all internet-related property values of this instance to the PC.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		public void Save()
		{
			string proxyHostPlusPort = ProxyHost;
			if (ProxyPort > 0)
				proxyHostPlusPort += ":" + ProxyPort;

			string proxyOverridePlusLocal = ProxyOverride;
			if (IsLocalBypassed)
				proxyOverridePlusLocal += ";<local>";

			using (RegistryKey registry = Registry.CurrentUser.OpenSubKey(Settings.Default.InternetSettingsHive, true))
			{
				if (registry == null)
					return;
				registry.SetValue("ProxyEnable", IsEnabled ? 1 : 0);
				registry.SetValue("ProxyServer", proxyHostPlusPort);
				registry.SetValue("ProxyOverride", proxyOverridePlusLocal);
			}

			// These lines cause the OS to refresh the settings, causing IP to really update
			bool retVal = NativeMethods.InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
			Debug.Assert(retVal);

			retVal = NativeMethods.InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
			Debug.Assert(retVal);
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Resets the property values of this instance back to the values that were last saved or to the factory default values.
		/// </summary>
		/// <param name="useFactoryDefaults">
		/// If set to <c>true</c>, the property values of this instance are reset back to the original factory default values
		/// obtained from the application config file; otherwise the property values are just reset to the values that were last
		/// saved.
		/// </param>
		/// <remarks>
		/// A save must still be performed in order to make the changes permanent.
		/// </remarks>
		//------------------------------------------------------------------------------------------------------------------------
		private void Reset(bool useFactoryDefaults = false)
		{
			if (useFactoryDefaults)
			{
				ProxyHost = Settings.Default.ProxyHost;
				ProxyOverride = Settings.Default.ProxyOverride;
				ProxyPort = Settings.Default.ProxyPort;
				IsLocalBypassed = Settings.Default.IsLocalBypassed;
				IsEnabled = Settings.Default.IsEnabled;
			}
			else
			{
				LoadProperties();
			}
		}

		#endregion

		//.................................................................................................................................

		#region Private Helper Methods

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Loads all the property values into this object.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		private void LoadProperties()
		{
			const string LOCAL = "<local>";
			using (RegistryKey registry = Registry.CurrentUser.OpenSubKey(Settings.Default.InternetSettingsHive, true))
			{
				if (registry == null)
					return;
				IsEnabled = Convert.ToBoolean(registry.GetValue("ProxyEnable", 0));
				string proxyHostPlusPort = registry.GetValue("ProxyServer", "").ToString();
				// Split it first on semicolons;
				string[] m = Regex.Split(proxyHostPlusPort, ";");
				if (m.Length > 0)
					// Split it again on colons.
					m = Regex.Split(m[0], ":");
				if (m.Length > 0)
					ProxyHost = m[0];
				if (m.Length > 1)
				{
					int port;
					if (int.TryParse(m[1], out port))
						ProxyPort = port;
				}
				ProxyOverride = registry.GetValue("ProxyOverride", "").ToString().Trim();
				int localIndex = ProxyOverride.IndexOf(LOCAL, StringComparison.Ordinal);
				if (localIndex > -1)
				{
					ProxyOverride = ProxyOverride.Remove(localIndex, LOCAL.Length).TrimEnd(';');
					IsLocalBypassed = true;
				}
				else
				{
					IsLocalBypassed = false;
				}
			}
		}

		//--------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Indicates whether the specified name is valid (i.e, value is null or empty or contains only the following 
		/// characters: [a-zA-Z0-9-.]).
		/// </summary>
		/// <param name="name">The name.</param>
		/// <returns><c>true</c> if the specified name is valid; otherwise, <c>false</c>.</returns>
		//--------------------------------------------------------------------------------------------------------------
		private static bool IsValidHostName(string name)
		{
			const string PATTERN = @"^[a-zA-Z0-9\-\.]*$";
			return string.IsNullOrEmpty(name) || Regex.IsMatch(name, PATTERN);
		}

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Indicates whether the specified proxy port number is valid (i.e, it is 0 or a number between 2 and 5 digits).
		/// </summary>
		/// <param name="proxyPort">The proxy port number.</param>
		/// <returns><c>true</c> if the specified proxy port number is valid; otherwise, <c>false</c>.</returns>
		//------------------------------------------------------------------------------------------------------------------------
		private static bool IsValidProxyPort(int proxyPort)
		{
			return proxyPort == 0 || proxyPort > 9 && proxyPort <= 99999;
		}

		#endregion
	}
}