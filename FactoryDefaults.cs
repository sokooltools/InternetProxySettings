namespace Parker.Tucson.InternetSettings
{
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Provides static readonly values for resetting the properties of NetworkSettings, SystemSettings, and InternetSettings 
	/// objects back to their original factory defaults;
	/// </summary>
	/// <remarks>
	/// Used in lieu of the standard C# 'Settings' class / 'app.config' file since these are not supported in Windows CE.
	/// </remarks>
	//---------------------------------------------------------------------------------------------------------------------------
	internal sealed class FactoryDefaults
	{
		static FactoryDefaults()
		{
			// This stuff could ultimately be read/initialized from an xml file.
			DHCPEnabled = false;
			DNSEnabledForWINSResolution = false;
			DomainDNSRegistrationEnabled = false;
			FullDNSRegistrationEnabled = false;
			IPEnabled = true;
			IsEnabled = true;
			IsLocalBypassed = true;
			WINSEnableLMHostsLookup = false;
			ProxyPort = 80;
			DefaultIPGateway = "";
			DHCPServer = "";
			DNSDomain = "";
			DNSDomainSuffixSearchOrder = "";
			DNSPrimaryServer = "";
			DNSSecondaryServer = "";
			InternetSettingsHive = "Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Internet Settings";
			IPAddress = "10.10.10.1";
			IPSubnet = "255.255.255.0";
			ProxyHost = "phproxy1";
			ProxyOverride = "*.parker.corp;*.us.parker.corp;*.parker.com;172.29.*.*";
			WINSHostLookupFile = "";
			WINSPrimaryServer = "";
			WINSScopeID = "";
			WINSSecondaryServer = "";
			GatewayCostMetric = 0;
		}

		public static readonly bool DHCPEnabled;
		public static readonly bool DNSEnabledForWINSResolution;
		public static readonly bool DomainDNSRegistrationEnabled;
		public static readonly bool FullDNSRegistrationEnabled;
		public static readonly bool IPEnabled = true;
		public static readonly bool IsEnabled = true;
		public static readonly bool IsLocalBypassed = true;
		public static readonly bool WINSEnableLMHostsLookup;
		public static readonly int ProxyPort;
		public static readonly string DefaultIPGateway;
		public static readonly string DHCPServer;
		public static readonly string DNSDomain;
		public static readonly string DNSDomainSuffixSearchOrder;
		public static readonly string DNSPrimaryServer;
		public static readonly string DNSSecondaryServer;
		public static readonly string InternetSettingsHive;
		public static readonly string IPAddress;
		public static readonly string IPSubnet;
		public static readonly string ProxyHost;
		public static readonly string ProxyOverride;
		public static readonly string WINSHostLookupFile;
		public static readonly string WINSPrimaryServer;
		public static readonly string WINSScopeID;
		public static readonly string WINSSecondaryServer;
		public static readonly ushort GatewayCostMetric;
	}
}
