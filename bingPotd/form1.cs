using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace bingPotd
{
    public partial class Form1 : Form
    {
        RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        bool enabled;
        public Form1()
        {
            InitializeComponent();
            if (Registry.GetValue( key.ToString() , "bingPotd", null) == null) {
                //if key Not Exist
                enabled = false;
                setStatus(enabled);
            }
            else {
                //if key Exist
                enabled = true;
                setStatus(enabled);
            }
        }

        private void bEnable_Click(object sender, EventArgs e) {
            if(enabled == false) {
                key.SetValue("bingPotd", "\"" + System.Reflection.Assembly.GetEntryAssembly().Location + "\" -auto");
                enabled = true;
                setStatus(enabled);
            }
            
        }

        private void bDisable_Click(object sender, EventArgs e) {
            if (enabled == true) {
                key.DeleteValue("bingPotd", false);
                enabled = false;
                setStatus(enabled);
            }
        }

        private void setStatus(bool newState) {
            if(newState == true) {
                lStatus.Text = "enabled";
                lStatus.ForeColor = Color.Green;
            }
            if (newState == false) {
                lStatus.Text = "disabled";
                lStatus.ForeColor = Color.Red;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(enabled == true) {
                DialogResult dialogResult = MessageBox.Show("Do you want to change the wallpaper now?", "BingPotd", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Program.DownloadAndSetImg();
            }

        }
    }
}
