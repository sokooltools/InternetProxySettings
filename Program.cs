using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace InternetProxySettings
{
	public static class Program
	{
		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		[STAThread]
		private static void Main(string[] args)
		{
			try
			{
				bool shiftKeyIsDown = NativeMethods.MyKeyBoard.GetKeyState(NativeMethods.MyKeyBoard.VK_LSHIFT) < 0;

				// Show the UI when an argument is specified or the <Shift> key is being held down during startup.
				if (args.Length == 0 || shiftKeyIsDown)
				{
					// Show the dialog window.
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new MainForm());
				}
				else
				{
					// Disable the internet proxy without showing a UI.
					var internetSettings = new InternetSettings {IsEnabled = args.Length > 0 && args[0] == "1"};
					Debug.Assert(internetSettings != null);
					internetSettings.Save();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, @"Internet Proxy Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			Application.Exit();
		}
	}

	
}