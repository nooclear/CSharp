using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamAccountManager
{
    public partial class Main : Form
    {
        public bool settings = true;

        public Main()
        {
            InitializeComponent();
        }

        public void setView()
        {
            if (settings)
            {
                gb_Settings.Visible = true;
            }
            else
            {
                gb_Settings.Visible = false;
            }
        }

        private void btn_ChangeSteamLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txt_SteamTextLoc.Text = fbd.SelectedPath.ToString();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            if (settings)
            {
                settings = false;
            }
            else
            {
                settings = true;
            }
            setView();
        }
    }
}
