using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Win32;

namespace SetPrpxy
{
    public partial class FormSetProxy : Form
    {
        string proxyUrl;
        string pacUrl = ConfigurationManager.AppSettings["pacUrl"];
        string server = ConfigurationManager.AppSettings["proxyServer"];
        string port = ConfigurationManager.AppSettings["proxyPort"];
        string user = ConfigurationManager.AppSettings["authUser"];
        string pass = ConfigurationManager.AppSettings["authPassword"];
        RegistryKey registry = Registry.CurrentUser
                               .OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);


        public FormSetProxy()
        {
            InitializeComponent();
            proxyUrl = "http://" + user + ":" + pass + "@" + server + ":" + port;
        }

        private void BtnEnable_Click(object sender, EventArgs e)
        {
            SetEnvironment(true);

            MessageBox.Show("プロキシが有効になりました",
                            "Info");
        }

        private void BtnDisable_Click(object sender, EventArgs e)
        {
            SetEnvironment(false);


            MessageBox.Show("プロキシが無効になりました",
                            "Info");
        }

        private void SetEnvironment(bool isValid)
        {
            var proxy = isValid ? proxyUrl : null;
            int isEnable = isValid ? 1 :0;

            Environment.SetEnvironmentVariable("HTTP_PROXY", proxy, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("HTTPS_PROXY", proxy, EnvironmentVariableTarget.User);

            registry.SetValue("ProxyEnable", isEnable);
            
            if (isValid)
            {
                registry.SetValue("AutoConfigURL", pacUrl);
            }
            else
            {
                registry.DeleteValue("AutoConfigURL");
            }

        }
    }
}
