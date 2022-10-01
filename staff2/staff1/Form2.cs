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
    public partial class Form2 : Form
    {
        Global global = new Global();
        File_Names fn = new File_Names();
        CheckForExisting cfe = new CheckForExisting();
        private readonly Form1 _form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this._form1 = form1;
        }

        // Initialization Stuff

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

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            global.UpdateList(sorts, areas);
        }

        // Add Employee

        private void add_btn_Click(object sender, EventArgs e)
        {
            List<string> Lines = new List<string>(File.ReadAllLines(fn.Users));

            bool nameEmpty = (name_txt.Text == ""), sortEmpty = (sorts.SelectedIndex == -1), areaEmpty = (areas.SelectedIndex == -1);
            
            if (nameEmpty == true || sortEmpty == true || areaEmpty == true)
            {
                global.ReturnMissingInfo(nameEmpty, sortEmpty, areaEmpty);
            }
            else if (cfe.Single(name_txt.Text) == false)
            {
                NE emp = new NE
                {
                    name = name_txt.Text,
                    sort_name = sorts.SelectedItem.ToString(),
                    area = areas.SelectedItem.ToString(),
                    start = "",
                    stop = ""
                };

                string json = JsonConvert.SerializeObject(emp, Formatting.Indented);

                string js = "";

                using (StreamReader sr = new StreamReader("j.json"))
                {
                    js = sr.ReadToEnd();
                    string newJ = ',' + json + '\n' + ']';
                    if (js.Contains("name"))
                    {
                        js = js.Replace("]", "");
                        js = js + ',' + json + '\n' + ']';
                    }
                    else
                    {
                        js = js.Replace("]", string.Empty);
                        js = js + json + '\n' + ']';
                    }
                }
                File.WriteAllText("j.json", js);

                this._form1.readJson();
                this._form1.calculate();
                this._form1.log();
                this.Close();
            }
        }

        // Cancel Adding

        private void cancel_btn_Click(object sender, EventArgs e)
        {
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
