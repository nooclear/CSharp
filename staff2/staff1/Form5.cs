using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staff1
{
    public partial class Form5 : Form
    {
        // Initialization Stuff
        private readonly Form1 _form1;
        File_Names fn = new File_Names();
        public Form5(Form1 form1)
        {
            InitializeComponent();
            this._form1 = form1;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Read("Area");
            Read("Sort");
        }
        
        // Read and Write

        public void Read(string type)
        {
            switch (type)
            {
                case "Area":
                    foreach (string line in File.ReadAllLines(fn.Areas))
                        area_listbox.Items.Add(line);
                    break;
                case "Sort":
                    foreach (string line in File.ReadAllLines(fn.Sorts))
                        sort_listbox.Items.Add(line);
                    break;
            }
        }

        public void Write(string type)
        {
            List<string> Areas = new List<string>();
            List<string> Sorts = new List<string>();
            switch (type)
            {
                case "Area":
                    foreach(string item in area_listbox.Items)
                    {
                        Areas.Add(item);
                    }
                    File.WriteAllLines(fn.Areas, Areas);
                    break;
                case "Sort":
                    foreach(string item in sort_listbox.Items)
                    {
                        Sorts.Add(item);
                    }
                    File.WriteAllLines(fn.Sorts, Sorts);
                    break;
            }
        }

        // Sort Stuff

        private void Sort_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sort_listbox.SelectedIndex >= 0)
            {
                sort_selected.Text = sort_listbox.SelectedItem.ToString();
            }
        }

        private void Sort_add_Click(object sender, EventArgs e)
        {
            if(sort_selected.Text != "" && !sort_listbox.Items.Contains(sort_selected.Text))
            {
                sort_listbox.Items.Add(sort_selected.Text);
                sort_selected.Text = "";
                Write("Sort");
                this._form1.GetFilters();
                this._form1.WriteFilters();
                this._form1.CheckFilters();
            }
        }

        private void Sort_remove_Click(object sender, EventArgs e)
        {
            if(sort_listbox.SelectedItem.ToString() != "")
            {
                sort_listbox.Items.Remove(sort_listbox.SelectedItem);
                sort_selected.Text = "";
                Write("Sort");
                this._form1.GetFilters();
                this._form1.WriteFilters();
                this._form1.CheckFilters();
            }
        }

        // Area Stuff

        private void Area_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(area_listbox.SelectedIndex >= 0)
            {
                area_selected.Text = area_listbox.SelectedItem.ToString();
            }
        }

        private void Area_add_Click(object sender, EventArgs e)
        {
            if(area_selected.Text != "" && !area_listbox.Items.Contains(area_selected.Text))
            {
                area_listbox.Items.Add(area_selected.Text);
                area_selected.Text = "";
                Write("Area");
                this._form1.GetFilters();
                this._form1.WriteFilters();
                this._form1.CheckFilters();
            }
        }

        private void Area_remove_Click(object sender, EventArgs e)
        {
            if(area_listbox.SelectedItem.ToString() != "")
            {
                area_listbox.Items.Remove(area_listbox.SelectedItem);
                area_selected.Text = "";
                Write("Area");
                
                this._form1.GetFilters();
                this._form1.WriteFilters();
                this._form1.CheckFilters();
            }
        }
    }
}
