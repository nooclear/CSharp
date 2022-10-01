using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace staff1
{
    public partial class Form3 : Form
    {
        private readonly Form1 _form1;

        public Form3(Form1 form1)
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public string selected_name = Form1.selected_name;
        public string selected_sort = Form1.selected_sort;
        public string selected_area = Form1.selected_area;

        private void Form3_Load(object sender, EventArgs e)
        {
            Global global = new Global();
            global.UpdateList(sorts, areas);

            name_txt.Text = selected_name;
            sorts.SelectedItem = selected_sort;
            areas.SelectedItem = selected_area;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>(File.ReadAllLines("j.json"));

            for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i] == "  \"name\": \"" + selected_name + "\",")
                {
                    lines[i] = lines[i].Replace(selected_name, name_txt.Text);
                    if(selected_sort != "")
                        lines[i + 1] = lines[i + 1].Replace(selected_sort, sorts.SelectedItem.ToString());
                    if(selected_area != "")
                        lines[i + 2] = lines[i + 2].Replace(selected_area, areas.SelectedItem.ToString());
                }
            }
            File.WriteAllLines("j.json", lines);

            this._form1.readJson();
            this._form1.calculate();
            this.Close();
        }
       
        // Disallow selection of index 0

        private void Sorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sorts.SelectedIndex == 0)
                sorts.SelectedIndex = 1;
        }

        private void Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (areas.SelectedIndex == 0)
                areas.SelectedIndex = 1;
        }
    }
}