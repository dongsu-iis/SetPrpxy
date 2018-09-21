using Microsoft.Win32;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace SetPrpxy
{
    public partial class FormSetProxy : Form
    {

        string pacUrl = ConfigurationManager.AppSettings["pacUrl"];
        string server = ConfigurationManager.AppSettings["proxyServer"];
        string port = ConfigurationManager.AppSettings["proxyPort"];
        string user = ConfigurationManager.AppSettings["authUser"];
        string pass = ConfigurationManager.AppSettings["authPassword"];
        string proxyUrl = "";

        RegistryKey registry = Registry.CurrentUser
                               .OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);


        public FormSetProxy()
        {
            InitializeComponent();
            proxyUrl = $"http://{user}:{pass}@{server}:{port}";
        }

        private void BtnEnable_Click(object sender, EventArgs e)
        {
            try
            {
                SetEnvReg(true);
                MessageBox.Show("プロキシが有効になりました", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDisable_Click(object sender, EventArgs e)
        {
            try
            {
                SetEnvReg(false);
                MessageBox.Show("プロキシが無効になりました", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 環境変数とレジストリを設定する
        /// </summary>
        /// <param name="isValid">プロキシOn/Off</param>
        private void SetEnvReg(bool isValid)
        {

            if (isValid)
            {
                registry.SetValue("ProxyEnable", 1);
                registry.SetValue("AutoConfigURL", pacUrl);

                Environment.SetEnvironmentVariable("HTTP_PROXY", proxyUrl, EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("HTTPS_PROXY", proxyUrl, EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("chocolateyProxyUser", user, EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("chocolateyProxyPassword", pass, EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("chocolateyProxyLocation", $"{server}:{port}", EnvironmentVariableTarget.User);
            }
            else
            {
                registry.SetValue("ProxyEnable", 0);

                var pac = registry.GetValue("AutoConfigURL");
                if (pac != null)
                {
                    registry.DeleteValue("AutoConfigURL");
                }

                Environment.SetEnvironmentVariable("HTTP_PROXY", null, EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("HTTPS_PROXY", null, EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("chocolateyProxyUser", null, EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("chocolateyProxyPassword", null, EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("chocolateyProxyLocation", null, EnvironmentVariableTarget.User);
            }

        }
    }
}
