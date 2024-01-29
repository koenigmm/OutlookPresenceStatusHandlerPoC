using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookPresenceStatusHandlerPoC
{
    public partial class Form1 : Form
    {
        //TODO Should get current Provider from registry
        private IMProvider _currentProvider;

        private IMProvider _selectedProvider;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("HKEY_CURRENT_USER\\Software\\IM Providers");
            using (RegistryKey IMDefaultProviderKey = Registry.CurrentUser.OpenSubKey("Software\\IM Providers", true))
            {
                if (IMDefaultProviderKey == null) return;
                IMDefaultProviderKey.SetValue("DefaultIMApp", GetRegistryValueFromProviderEnum(_selectedProvider), RegistryValueKind.String);
            }
        }

        private void WebexButton_CheckedChanged(object sender, EventArgs e)
        {
            //TODO Placeholder
            _selectedProvider = IMProvider.Webex;
        }

        private void SkypeButton_CheckedChanged(object sender, EventArgs e)
        {
            //TODO Placeholder
            _selectedProvider = IMProvider.Lync;
        }

        private string GetRegistryValueFromProviderEnum(IMProvider provider)
        {
            string registryValue;
            const string lyncValue = "Lync";
            const string WebexValue = "Cisco Spark";


            switch (provider)
            {

                case IMProvider.Lync:
                    registryValue = lyncValue;
                    break;
                case IMProvider.Webex:
                    registryValue = WebexValue;
                    break;

                default:
                    registryValue = lyncValue;
                    break;
            }

            return registryValue;
        }
    }
}
