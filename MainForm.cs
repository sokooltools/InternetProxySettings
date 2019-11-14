using System;
using System.Globalization;
using System.Windows.Forms;

namespace InternetProxySettings
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			InternetSettings = new InternetSettings();
		}

		private InternetSettings InternetSettings { get; }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			chkIsEnabled.Checked = InternetSettings.IsEnabled;
			chkIsLocalBypassed.Checked = InternetSettings.IsLocalBypassed;
			txtProxyHost.Text = InternetSettings.ProxyHost;
			txtProxyPort.Text = InternetSettings.ProxyPort.ToString(CultureInfo.InvariantCulture);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			btnOK.Focus();
		}

		private void chkIsEnabled_CheckStateChanged(object sender, EventArgs e)
		{
			bool isEnabled = ((CheckBox) sender).Checked;
			lblProxyHost.Enabled = isEnabled;
			txtProxyHost.Enabled = isEnabled;
			lblProxyPort.Enabled = isEnabled;
			txtProxyPort.Enabled = isEnabled;
			btnAdvanced.Enabled = isEnabled;
			chkIsLocalBypassed.Enabled = isEnabled;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			InternetSettings.IsEnabled = chkIsEnabled.Checked;
			InternetSettings.IsLocalBypassed = chkIsLocalBypassed.Checked;
			InternetSettings.ProxyHost = txtProxyHost.Text;
			InternetSettings.ProxyPort = int.Parse(txtProxyPort.Text);
			InternetSettings.Save();
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnAdvanced_Click(object sender, EventArgs e)
		{
			using (var dlg = new ProxySettingsDialog())
			{
				dlg.txtHttp.Text = txtProxyHost.Text;
				dlg.txtHttpPort.Text = txtProxyPort.Text;
				dlg.txtSecure.Text = txtProxyHost.Text;
				dlg.txtSecurePort.Text = txtProxyPort.Text;
				dlg.txtFtp.Text = txtProxyHost.Text;
				dlg.txtFtpPort.Text = txtProxyPort.Text;
				dlg.chkSameProxyForAll.Checked = true;
				dlg.txtProxyOverride.Text = InternetSettings.ProxyOverride;
				if (dlg.ShowDialog() != DialogResult.OK)
					return;
				InternetSettings.ProxyOverride = dlg.txtProxyOverride.Text;
				txtProxyHost.Text = dlg.txtHttp.Text;
				txtProxyPort.Text = dlg.txtHttpPort.Text;
			}
		}
	}
}