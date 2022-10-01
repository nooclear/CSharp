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
using System.Runtime.InteropServices.WindowsRuntime;

namespace staff1
{
    public partial class Form4 : Form
    {
        Global global = new Global();
        CheckForExisting cfe = new CheckForExisting();
        private readonly Form1 _form1;

        public Form4(Form1 form1)
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

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void add_to_lB1_Click(object sender, EventArgs e)
        {
            if(!lB1.Items.Contains(employee_name_txtbox.Text))
                lB1.Items.Add(employee_name_txtbox.Text);
            employee_name_txtbox.Text = "";
        }

        private void remove_from_lB1_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            foreach (string item in lB1.Items)
                items.Add(item);
            if (items.Contains(employee_name_txtbox.Text))
                items.Remove(employee_name_txtbox.Text);
            lB1.Items.Clear();
            foreach(string item in items)
                lB1.Items.Add(item);
            employee_name_txtbox.Text = "";
            this._form1.log();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_all_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            foreach (string item in lB1.Items)
                lines.Add(item);

            bool nameEmpty = (lB1.Items.Count == 0), sortEmpty = (sorts.SelectedIndex == -1), areaEmpty = (areas.SelectedIndex == -1);
            if (nameEmpty == true || sortEmpty == true || areaEmpty == true)
            {
                global.ReturnMissingInfo(nameEmpty, sortEmpty, areaEmpty);
            }
            else if(cfe.Multiple(lB1.Items).Count() > 0)
            {
                string combined = "";
                foreach(var item in cfe.Multiple(lB1.Items))
                    combined += item + "\n";
                MessageBox.Show("User(s) already exist\n" + combined);
            }
            else if (cfe.Multiple(lB1.Items).Count() == 0)
            {
                foreach (string item in lines)
                {
                    NE emp = new NE
                    {
                        name = item,
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
                    this.Close();
                }
            }            
        }

        private void lB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lB1.SelectedIndex != -1)
                employee_name_txtbox.Text = lB1.SelectedItem.ToString();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() != "")
            {
                List<string> items = new List<string>();
                foreach(string item in Clipboard.GetText().Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None))
                    lB1.Items.Add(item);
            }
        }

        // Add existing sorts and areas to listboxes

        private void Form4_Load(object sender, EventArgs e)
        {
            global.UpdateList(sorts, areas);
        }

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