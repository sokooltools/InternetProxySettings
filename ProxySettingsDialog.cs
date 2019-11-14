using System;
using System.Windows.Forms;

namespace InternetProxySettings
{
	public partial class ProxySettingsDialog : Form
	{
		public ProxySettingsDialog()
		{
			InitializeComponent();
		}

		private void chkSameProxyForAll_CheckedChanged(object sender, EventArgs e)
		{
			bool isEnabled = !((CheckBox) sender).Checked;
			txtSecure.Enabled = isEnabled;
			txtSecurePort.Enabled = isEnabled;
			txtFtp.Enabled = isEnabled;
			txtFtpPort.Enabled = isEnabled;
			txtSocks.Enabled = isEnabled;
			txtSocksPort.Enabled = isEnabled;
		}
	}
}