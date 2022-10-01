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
using System.Text.RegularExpressions;
using System.Threading;

namespace staff1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // global functions

        File_Names fn = new File_Names();
        Directories dir = new Directories();
        Global global = new Global();

        public class Employee
        {
            public string name { get; set; }
            public string sort_name { get; set; }
            public string area { get; set; }
            public string start { get; set; }
            public string stop { get; set; }
        }

        public void readJson()
        {
            list_view.Items.Clear();
            current_staffing = 0;
            current_left = 0;
            using (StreamReader sr = new StreamReader(fn.Users))
            {
                string js = sr.ReadToEnd();
                if (js != "")
                {
                    List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);

                    foreach (var item in emps)
                    {
                        ListViewItem lvi = new ListViewItem(item.name);
                        lvi.SubItems.Add(item.sort_name.ToString());
                        lvi.SubItems.Add(item.area.ToString());
                        lvi.SubItems.Add(item.start);
                        lvi.SubItems.Add(item.stop);
                        list_view.Items.Add(lvi);

                        if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                        {
                            lvi.ForeColor = Color.Lime;
                            current_staffing = current_staffing + 1;
                        }
                        else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                        {
                            lvi.ForeColor = Color.Red;
                            current_left = current_left + 1;
                        }
                    }
                }
            }
        }

        public void log()
        {
            if (logToolStripMenuItem1.Checked)
            {
                string date = DateTime.Now.ToString("MM-dd-yyyy");
                string time = DateTime.Now.ToString("HH-mm-ss") + ".json";

                if (!Directory.Exists(dir.Logs + '\\' + date))
                    Directory.CreateDirectory(dir.Logs+ '\\' + date);
                string path = Path.GetDirectoryName(Application.ExecutablePath) + '\\' + dir.Logs + '\\' + date + '\\';

                List<string> json = new List<string>();
                json.Add("[");
                foreach (ListViewItem item in list_view.Items)
                {
                    Employee emp = new Employee
                    {
                        name = item.SubItems[0].Text,
                        sort_name = item.SubItems[1].Text,
                        area = item.SubItems[2].Text,
                        start = item.SubItems[3].Text,
                        stop = item.SubItems[4].Text
                    };
                    json.Add(JsonConvert.SerializeObject(emp, Formatting.Indented));
                    json.Add(",");
                }
                json.RemoveAt(json.Count() - 1);
                json.Add("]");
                File.WriteAllLines(path + time, json);
            }
        }

        public void setFirstLast()
        {
            List<char> c = new List<char>(File.ReadAllText(fn.Users));
            char first = c[0];
            string last = c[(c.Count() - 3)].ToString();

            if (first != '[')
                c[0] = '[';
            if (c[c.Count()-3].ToString() != "]")
                c[c.Count() - 3] = ']';

            File.WriteAllText(fn.Users, c.ToString());
        }

        public void calculate()
        {
            staffing_display.Text = (current_staffing + current_newppl + current_change).ToString();
            staffing_left.Text = (current_left + left_change).ToString();
            new_total.Text = current_newppl.ToString();

            if (current_change == 0)
                staffing_display.ForeColor = Color.Lime;
            if (current_change > 0)
                staffing_display.ForeColor = Color.Magenta;
            if (current_change < 0)
                staffing_display.ForeColor = Color.Blue;

            if (left_change == 0)
                staffing_left.ForeColor = Color.Red;
            if (left_change > 0)
                staffing_left.ForeColor = Color.Magenta;
            if (left_change < 0)
                staffing_left.ForeColor = Color.Blue;

            staffing = (current_staffing + current_newppl + current_change).ToString();

            log();
        }

        // Main strings and integers

        public static string selected_name = "", selected_sort = "", selected_area = "", timestamp = "";
        public int current_staffing = 0, current_newppl = 0, current_left = 0, current_change = 0, left_change = 0;

        // init stuff

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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static string staffing = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir.Logs))
                Directory.CreateDirectory(dir.Logs);
            if (!Directory.Exists(dir.Exports))
                Directory.CreateDirectory(dir.Exports);
            if (!File.Exists(fn.Users))
            {
                using (StreamWriter sw = File.CreateText(fn.Users))
                {
                    sw.WriteLine('[');
                    sw.WriteLine(']');
                }
            }
            else
            {
                string[] lines = File.ReadAllLines(fn.Users).Where(s => s.Trim() != string.Empty).ToArray();
                File.Delete(fn.Users);
                File.WriteAllLines(fn.Users, lines);
            }
            if (!File.Exists(fn.Areas))
                File.Create(fn.Areas);
            if (!File.Exists(fn.Sorts))
                File.Create(fn.Sorts);
            if (!File.Exists(fn.Temp))
                File.Create(fn.Temp);
            readJson();
            GetFilters();
            WriteFilters();
            calculate();
        }

        // time in / out

        private void list_view_DoubleClick(object sender, EventArgs e)
        {
            try {
                if (list_view.SelectedItems[0].ForeColor == Color.White)
                {
                    current_staffing += 1;
                    calculate();
                    list_view.SelectedItems[0].ForeColor = Color.Lime;
                    timestamp = DateTime.Now.ToString("HH:mm:ss");
                    list_view.SelectedItems[0].SubItems[3].Text = timestamp;

                    List<string> lines = new List<string>(File.ReadAllLines(fn.Users));
                    for (int i = 0; i < File.ReadAllLines(fn.Users).Count(); i++)
                    {
                        if (lines[i] == "  \"name\": \"" + list_view.SelectedItems[0].Text + "\",")
                        {
                            lines[i + 3] = "  \"start\": \"" + list_view.SelectedItems[0].SubItems[3].Text + "\",";
                            break;
                        }
                    }

                    File.WriteAllLines(fn.Users, lines);

                    list_view.SelectedItems[0].Selected = false;
                }
                else if (list_view.SelectedItems[0].ForeColor == Color.Lime)
                {
                    current_staffing -= 1;
                    current_left += 1;
                    calculate();

                    list_view.SelectedItems[0].ForeColor = Color.Red;
                    timestamp = DateTime.Now.ToString("HH:mm:ss");
                    list_view.SelectedItems[0].SubItems[4].Text = timestamp;

                    List<string> lines = new List<string>(File.ReadAllLines(fn.Users));
                    for (int i = 0; i < File.ReadAllLines(fn.Users).Count(); i++)
                    {
                        if (lines[i] == "  \"name\": \"" + list_view.SelectedItems[0].Text + "\",")
                        {
                            lines[i + 4] = "  \"stop\": \"" + list_view.SelectedItems[0].SubItems[4].Text + "\"";
                            break;
                        }
                    }
                    File.WriteAllLines(fn.Users, lines);

                    list_view.SelectedItems[0].Selected = false;
                }
                else if (list_view.SelectedItems[0].ForeColor == Color.Red)
                {
                    DialogResult reset = MessageBox.Show("Reset Timestamps?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (reset == DialogResult.Yes)
                    {
                        list_view.SelectedItems[0].ForeColor = Color.FromName("white");
                        timestamp = DateTime.Now.ToString("HH:" +
                            "mm:ss");
                        list_view.SelectedItems[0].SubItems[3].Text = "";
                        list_view.SelectedItems[0].SubItems[4].Text = "";

                        List<string> lines = new List<string>(File.ReadAllLines(fn.Users));
                        for (int i = 0; i < File.ReadAllLines(fn.Users).Count(); i++)
                        {
                            if (lines[i] == "  \"name\": \"" + list_view.SelectedItems[0].Text + "\",")
                            {
                                lines[i + 3] = "  \"start\": \"\",";
                                lines[i + 4] = "  \"stop\": \"\"";
                                break;
                            }
                        }
                        File.WriteAllLines(fn.Users, lines);

                        list_view.SelectedItems[0].Selected = false;
                        current_left -= 1;
                        calculate();
                    }
                }
                else if (list_view.SelectedItems[0].ForeColor == Color.RoyalBlue)
                {
                    selected_name = list_view.SelectedItems[0].Text;
                    selected_sort = list_view.SelectedItems[0].SubItems[1].Text;
                    selected_area = list_view.SelectedItems[0].SubItems[2].Text;
                    Form3 f3 = new Form3(this);
                    f3.Show();
                }
            }
            catch(Exception)
            {
                //string loc = "Crash " + DateTime.Now.ToString("MM -dd,yyyy    HH-mm-ss");
                //File.CreateText(loc);
                //File.WriteAllText(loc, ex.ToString());

                //MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            log();
        }

        // searching

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            list_view.Items.Clear();
            using (StreamReader sr = new StreamReader(fn.Users))
            {
                string js = sr.ReadToEnd();
                List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);

                foreach (var item in emps)
                {
                    if (item.name.ToUpper().Contains(search_box.Text.ToUpper()))
                    {
                        ListViewItem lvi = new ListViewItem(item.name);
                        lvi.SubItems.Add(item.sort_name.ToString());
                        lvi.SubItems.Add(item.area.ToString());
                        lvi.SubItems.Add(item.start);
                        lvi.SubItems.Add(item.stop);
                        list_view.Items.Add(lvi);

                        if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                        {
                            lvi.ForeColor = Color.Lime;
                        }
                        else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                        {
                            lvi.ForeColor = Color.Red;
                        }
                        CheckFilters();
                    }
                }
            }
        }

        // manual edit of staffing

        private void add_current_Click(object sender, EventArgs e)
        {
            current_change += 1;
            calculate();
            log();
        }

        private void sub_current_Click(object sender, EventArgs e)
        {
            current_change -= 1;
            calculate();
            log();
        }

        private void add_left_Click(object sender, EventArgs e)
        {
            left_change += 1;
            calculate();
            log();
        }

        private void sub_left_Click(object sender, EventArgs e)
        {
            left_change -= 1;
            calculate();
            log();
        }

        private void new_inc_Click(object sender, EventArgs e)
        {
            current_newppl = current_newppl + 1;
            calculate();
        }

        private void new_sub_Click(object sender, EventArgs e)
        {
            if (current_newppl - 1 >= 0)
            {
                current_newppl = current_newppl - 1;
                current_left = current_left + 1;
                calculate();
            }
        }

        // Adjust Employees

        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void multipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            f4.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selected_name = list_view.SelectedItems[0].Text;
            selected_sort = list_view.SelectedItems[0].SubItems[1].Text;
            selected_area = list_view.SelectedItems[0].SubItems[2].Text;
            Form3 f3 = new Form3(this);
            f3.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = list_view.SelectedItems[0].Text;

            List<string> lines = new List<string>(File.ReadAllLines(fn.Users));

            for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i] == "  \"name\": \"" + name + "\",")
                {
                    lines[i - 1] = "";
                    lines[i] = "";
                    lines[i + 1] = "";
                    lines[i + 2] = "";
                    lines[i + 3] = "";
                    lines[i + 4] = "";
                    lines[i + 5] = "";
                    if (lines[i + 6].Contains(',') && lines[i-1].Contains('}'))
                        lines[i + 6] = "{";
                }
            }

            File.WriteAllLines(fn.Users, lines);

            string[] Stuff = File.ReadAllLines(fn.Users).Where(s => s.Trim() != string.Empty).ToArray();
            File.Delete(fn.Users);
            File.WriteAllLines(fn.Users, Stuff);

            calculate();
            log();
            readJson();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>(File.ReadAllLines(fn.Users));
            for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i].Contains("start"))
                {
                    lines[i] = "  \"start\": \"\",";
                    lines[i + 1] = "  \"stop\": \"\"";
                }
            }
            File.WriteAllLines(fn.Users, lines);
            readJson();

            current_left = 0;
            current_change = 0;
            current_newppl = 0;
            left_change = 0;
            current_staffing = 0;

            staffing_display.Text = current_staffing.ToString();
            staffing_display.ForeColor = Color.Lime;
            staffing_left.Text = current_left.ToString();
            staffing_left.ForeColor = Color.Red;
            new_total.Text = current_newppl.ToString();
            new_total.ForeColor = Color.Cyan;
            log();
        }

        // Exporting

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iSorts = 0;
            int iAreas = Sorts.Count() + 1;
            if (filterByList.SelectedItems.ToString() != "" && filterByList.SelectedItems[0].ForeColor != Color.White)
            {
                filterByList.SelectedItems[0].ForeColor = Color.Lime;
                if (filterByList.SelectedIndices[0] < iAreas && filterByList.SelectedIndices[0] > iSorts)
                    Export("Sort", filterByList.SelectedItems[0].Text);
                else if (filterByList.SelectedIndices[0] > iAreas && filterByList.SelectedIndices[0] < iAreas + 1 + Areas.Count())
                    Export("Area", filterByList.SelectedItems[0].Text);
                else
                    Export("Custom", filterByList.SelectedItems[0].Text);
            }
            else if (filterByList.SelectedItems.ToString() != "" &&filterByList.SelectedItems[0].ForeColor != Color.White)
            {
                filterByList.SelectedItems[0].ForeColor = Color.Red;
                if (filterByList.SelectedIndices[0] < iAreas && filterByList.SelectedIndices[0] > iSorts)
                    Export("Sort", filterByList.SelectedItems[0].Text);
                else if (filterByList.SelectedIndices[0] > iAreas && filterByList.SelectedIndices[0] < iAreas + 1 + Areas.Count())
                    Export("Area", filterByList.SelectedItems[0].Text);
                else
                    Export("Custom", filterByList.SelectedItems[0].Text);
            }
        }

        public void Export(string type, string filter)
        {
            if (type == "Sort")
                exportSort(filter);
            else if (type == "Area")
                exportArea(filter);
            else if (type == "Custom")
                exportWork(filter);
        }
        public void exportArea(string area)
        {
            using (StreamReader sr = new StreamReader(fn.Users))
            {
                string js = sr.ReadToEnd();
                List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);
                List<string> lines = new List<string>();

                string date = DateTime.Now.ToString("MM-dd-yyyy");
                string time = DateTime.Now.ToString("HH-mm-ss") + "    " + area + ".json";

                if (!Directory.Exists(dir.Exports + '\\' + date))
                    Directory.CreateDirectory(dir.Exports + '\\' + date);
                string path = Path.GetDirectoryName(Application.ExecutablePath) + '\\' + dir.Exports + '\\' + date + '\\';

                foreach (var item in emps)
                {
                    if (item.area == area)
                    {
                        lines.Add(item.name);
                    }
                }

                lines.Sort();

                using (StreamWriter sw = File.CreateText(path + time))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                global.SendToPrinter(path + time);
            }
            log();
        }
        public void exportWork(string work)
        {
            using (StreamReader sr = new StreamReader(fn.Users))
            {
                string js = sr.ReadToEnd();
                List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);
                List<string> lines = new List<string>();

                string date = DateTime.Now.ToString("MM-dd-yyyy");
                string time = DateTime.Now.ToString("HH-mm-ss") + "    " + work + ".json";

                if (!Directory.Exists(dir.Exports + '\\' + date))
                    Directory.CreateDirectory(dir.Exports + '\\' + date);
                string path = Path.GetDirectoryName(Application.ExecutablePath) + '\\' + dir.Exports + '\\' + date + "\\";

                foreach (var item in emps)
                {
                    if (work == "Current Staffing")
                    {
                        if (item.start != "" && item.stop == "")
                            lines.Add(item.name);
                    }
                    else if (work == "Staff Who Left")
                    {
                        if (item.start != "" && item.stop != "")
                            lines.Add(item.name);
                    }
                    else if (work == "Staff That Worked")
                    {
                        if (item.start != "" || item.stop != "")
                            lines.Add(item.name);
                    }
                    else if (work == "Staff That Didn't Work")
                    {
                        if (item.start == "" && item.stop == "")
                            lines.Add(item.name);
                    }

                }

                lines.Sort();

                using (StreamWriter sw = File.CreateText(path + time))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                global.SendToPrinter(path + time);
            }
            log();
        }
        public void exportSort(string sort)
        {
            using (StreamReader sr = new StreamReader(fn.Users))
            {
                string js = sr.ReadToEnd();
                List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);
                List<string> lines = new List<string>();

                string date = DateTime.Now.ToString("MM-dd-yyyy");
                string time = DateTime.Now.ToString("HH-mm-ss") + "    " + sort + ".json";

                if (!Directory.Exists(dir.Exports + '\\' + date))
                    Directory.CreateDirectory(dir.Exports + '\\' + date);
                string path = Path.GetDirectoryName(Application.ExecutablePath) + '\\' + dir.Exports + '\\' + date + "\\";

                foreach (var item in emps)
                {
                    if (item.sort_name == sort)
                    {
                        lines.Add(item.name);
                    }
                }

                lines.Sort();

                using (StreamWriter sw = File.CreateText(path + time))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                global.SendToPrinter(path + time);
            }
            log();
        }

        //show log

        private void oldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + '\\' + dir.Exports;
            fd.Filter = "Json files (*.json)|*.json";

            if(fd.ShowDialog() == DialogResult.OK)
            {
                var filepath = fd.FileName;

                list_view.Items.Clear();

                using (StreamReader sr = new StreamReader(filepath))
                {
                    string js = sr.ReadToEnd();
                    if (js != "")
                    {
                        List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);

                        foreach (var item in emps)
                        {
                            ListViewItem lvi = new ListViewItem(item.name);
                            lvi.SubItems.Add(item.sort_name.ToString());
                            lvi.SubItems.Add(item.area.ToString());
                            lvi.SubItems.Add(item.start);
                            lvi.SubItems.Add(item.stop);
                            list_view.Items.Add(lvi);

                            if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                            {
                                lvi.ForeColor = Color.Lime;
                                current_staffing = current_staffing + 1;
                            }
                            else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                            {
                                lvi.ForeColor = Color.Red;
                                current_left = current_left + 1;
                            }
                        }
                    }
                }
            }
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_view.Items.Clear();

            using (StreamReader sr = new StreamReader(fn.Users))
            {
                string js = sr.ReadToEnd();
                if (js != "")
                {
                    List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);

                    foreach (var item in emps)
                    {
                        ListViewItem lvi = new ListViewItem(item.name);
                        lvi.SubItems.Add(item.sort_name.ToString());
                        lvi.SubItems.Add(item.area.ToString());
                        lvi.SubItems.Add(item.start);
                        lvi.SubItems.Add(item.stop);
                        list_view.Items.Add(lvi);

                        if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                        {
                            lvi.ForeColor = Color.Lime;
                            current_staffing = current_staffing + 1;
                        }
                        else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                        {
                            lvi.ForeColor = Color.Red;
                            current_left = current_left + 1;
                        }
                    }
                }
            }
        }

        // sort and area stuff

        public List<string> Sorts = new List<string>();

        private void Button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(this);
            f6.Show();
        }

        public List<string> Areas = new List<string>();

        private void EditSortsAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
        }

        // Filtering by...

        public void CheckFilters()
        {
            foreach(ListViewItem item in list_view.Items)
            {
                if (!File.ReadAllLines(fn.Sorts).Contains(item.SubItems[1].Text))
                    item.ForeColor = Color.RoyalBlue;
                else if (item.SubItems[3].Text != "" && item.SubItems[4].Text == "")
                    item.ForeColor = Color.Lime;
                else if (item.SubItems[4].Text != "")
                    item.ForeColor = Color.Red;
                else
                    item.ForeColor = Color.White;

                if (!File.ReadAllLines(fn.Areas).Contains(item.SubItems[2].Text))
                    item.ForeColor = Color.RoyalBlue;
                else if (item.SubItems[3].Text != "" && item.SubItems[4].Text == "")
                    item.ForeColor = Color.Lime;
                else if (item.SubItems[4].Text != "")
                    item.ForeColor = Color.Red;
                else
                    item.ForeColor = Color.White;
            }
        }

        public void GetFilters()
        {
            Sorts.Clear();
            Areas.Clear();
            if (File.Exists(fn.Sorts))
            {
                foreach (string line in File.ReadAllLines(fn.Sorts))
                    Sorts.Add(line);
            }
            if(File.Exists(fn.Areas))
            {
                foreach (string line in File.ReadAllLines(fn.Areas))
                    Areas.Add(line);
            }

            Sorts.Sort();
            Areas.Sort();
        }

        public void WriteFilters()
        {
            filterByList.Items.Clear();
            filterByList.Items.Add("---------------------------------------------------Shifts---------------------------------------------------");
            foreach (string item in Sorts)
                filterByList.Items.Add(item).ForeColor = Color.Lime;
            filterByList.Items.Add("---------------------------------------------------Areas---------------------------------------------------");
            foreach (string item in Areas)
                filterByList.Items.Add(item).ForeColor = Color.Lime;
            filterByList.Items.Add("--------------------------------------------------Custom--------------------------------------------------");
            filterByList.Items.Add("Current Staffing").ForeColor = Color.Lime;
            filterByList.Items.Add("Staff Who Left").ForeColor = Color.Lime;
            filterByList.Items.Add("Staff That Worked").ForeColor = Color.Lime;
            filterByList.Items.Add("Staff That Didn't Work").ForeColor = Color.Lime;

            CheckFilters();
        }

        public void Filter(string type, string filter, bool status)
        {
            if (status == true)
            {
                if (type == "Sort")
                {
                    using (StreamReader sr = new StreamReader(fn.Users))
                    {
                        string js = sr.ReadToEnd();
                        List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);

                        foreach (var item in emps)
                        {
                            if (item.sort_name == filter)
                            {
                                ListViewItem lvi = new ListViewItem(item.name);
                                lvi.SubItems.Add(item.sort_name.ToString());
                                lvi.SubItems.Add(item.area.ToString());
                                lvi.SubItems.Add(item.start);
                                lvi.SubItems.Add(item.stop);
                                list_view.Items.Add(lvi);

                                if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                                    lvi.ForeColor = Color.Lime;
                                else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                                    lvi.ForeColor = Color.Red;
                            }
                        }
                    }
                }
                else if (type == "Area")
                {
                    using (StreamReader sr = new StreamReader(fn.Users))
                    {
                        string js = sr.ReadToEnd();
                        List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);

                        foreach (var item in emps)
                        {
                            if (item.area == filter)
                            {
                                ListViewItem lvi = new ListViewItem(item.name);
                                lvi.SubItems.Add(item.sort_name.ToString());
                                lvi.SubItems.Add(item.area.ToString());
                                lvi.SubItems.Add(item.start);
                                lvi.SubItems.Add(item.stop);
                                list_view.Items.Add(lvi);

                                if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                                    lvi.ForeColor = Color.Lime;
                                else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                                    lvi.ForeColor = Color.Red;
                            }
                        }
                    }
                }
                else if (type == "Custom")
                {
                    using (StreamReader sr = new StreamReader(fn.Users))
                    {
                        string js = sr.ReadToEnd();
                        if (js != "")
                        {
                            List<Employee> emps = JsonConvert.DeserializeObject<List<Employee>>(js);

                            foreach (var item in emps)
                            {
                                if (filter == "Current Staffing")
                                {
                                    if (item.start != "" && item.stop == "")
                                    {
                                        ListViewItem lvi = new ListViewItem(item.name);
                                        lvi.SubItems.Add(item.sort_name.ToString());
                                        lvi.SubItems.Add(item.area.ToString());
                                        lvi.SubItems.Add(item.start);
                                        lvi.SubItems.Add(item.stop);
                                        list_view.Items.Add(lvi);

                                        if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                                        {
                                            lvi.ForeColor = Color.Lime;
                                            current_staffing = current_staffing + 1;
                                        }
                                        else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                                        {
                                            lvi.ForeColor = Color.Red;
                                            current_left = current_left + 1;
                                        }
                                    }
                                }

                                else if (filter == "Staff Who Left")
                                {
                                    if (item.start != "" && item.stop != "")
                                    {
                                        ListViewItem lvi = new ListViewItem(item.name);
                                        lvi.SubItems.Add(item.sort_name.ToString());
                                        lvi.SubItems.Add(item.area.ToString());
                                        lvi.SubItems.Add(item.start);
                                        lvi.SubItems.Add(item.stop);
                                        list_view.Items.Add(lvi);

                                        if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                                        {
                                            lvi.ForeColor = Color.Lime;
                                            current_staffing = current_staffing + 1;
                                        }
                                        else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                                        {
                                            lvi.ForeColor = Color.Red;
                                            current_left = current_left + 1;
                                        }
                                    }
                                }

                                else if (filter == "Staff That Worked")
                                {
                                    if (item.start != "" || item.stop != "")
                                    {
                                        ListViewItem lvi = new ListViewItem(item.name);
                                        lvi.SubItems.Add(item.sort_name.ToString());
                                        lvi.SubItems.Add(item.area.ToString());
                                        lvi.SubItems.Add(item.start);
                                        lvi.SubItems.Add(item.stop);
                                        list_view.Items.Add(lvi);

                                        if (lvi.SubItems[3].Text != "")
                                        {
                                            lvi.ForeColor = Color.Lime;
                                            current_staffing = current_staffing + 1;
                                        }
                                        else if (lvi.SubItems[3].Text != "")
                                        {
                                            lvi.ForeColor = Color.Red;
                                            current_left = current_left + 1;
                                        }
                                    }
                                }

                                else if (filter == "Staff That Didn't Work")
                                {
                                    if (item.start == "" && item.stop == "")
                                    {
                                        ListViewItem lvi = new ListViewItem(item.name);
                                        lvi.SubItems.Add(item.sort_name.ToString());
                                        lvi.SubItems.Add(item.area.ToString());
                                        lvi.SubItems.Add(item.start);
                                        lvi.SubItems.Add(item.stop);
                                        list_view.Items.Add(lvi);

                                        if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                                        {
                                            lvi.ForeColor = Color.Lime;
                                            current_staffing = current_staffing + 1;
                                        }
                                        else if (lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                                        {
                                            lvi.ForeColor = Color.Red;
                                            current_left = current_left + 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (status == false)
            {
                if (type == "Sort")
                {
                    foreach (ListViewItem lvi in list_view.Items)
                    {
                        if (lvi.SubItems[1].Text == filter)
                            lvi.Remove();
                    }
                }
                else if (type == "Area")
                {
                    foreach (ListViewItem lvi in list_view.Items)
                    {
                        if (lvi.SubItems[2].Text == filter)
                            lvi.Remove();
                    }
                }
                else if (type == "Custom")
                {
                    foreach (ListViewItem lvi in list_view.Items)
                    {
                        if (filter == "Current Staffing" && lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text == "")
                            lvi.Remove();
                        else if (filter == "Staff Who Left" && lvi.SubItems[3].Text != "" && lvi.SubItems[4].Text != "")
                            lvi.Remove();
                        else if (filter == "Staff That Worked" && lvi.SubItems[3].Text != "")
                            lvi.Remove();
                        else if (filter == "Staff That Didn't Work" && lvi.SubItems[3].Text == "" && lvi.SubItems[4].Text == "")
                            lvi.Remove();
                    }
                }
            }
            CheckFilters();
            log();
        }

        private void FilterByList_DoubleClick(object sender, EventArgs e)
        {
            int iSorts = 0;
            int iAreas = Sorts.Count() + 1;
            int iCustom = iAreas + Areas.Count() + 1;

            if (filterByList.SelectedItems[0].Index > iCustom)
                filterByList.SelectedItems[0].ForeColor = Color.Lime;
            else if (filterByList.SelectedItems.ToString() != "" && filterByList.SelectedItems[0].ForeColor != Color.Lime && filterByList.SelectedItems[0].ForeColor != Color.White)
            {
                filterByList.SelectedItems[0].ForeColor = Color.Lime;
                if (filterByList.SelectedIndices[0] < iAreas && filterByList.SelectedIndices[0] > iSorts)
                    Filter("Sort", filterByList.SelectedItems[0].Text, true);
                else if (filterByList.SelectedIndices[0] > iAreas && filterByList.SelectedIndices[0] < iAreas + 1 + Areas.Count())
                    Filter("Area", filterByList.SelectedItems[0].Text, true);
                //else
                    //Filter("Custom", filterByList.SelectedItems[0].Text, true);
            }
            else if (filterByList.SelectedItems.ToString() != "" && filterByList.SelectedItems[0].ForeColor == Color.Lime && filterByList.SelectedItems[0].ForeColor != Color.White)
            {
                filterByList.SelectedItems[0].ForeColor = Color.Red;
                if (filterByList.SelectedIndices[0] < iAreas && filterByList.SelectedIndices[0] > iSorts)
                    Filter("Sort", filterByList.SelectedItems[0].Text, false);
                else if (filterByList.SelectedIndices[0] > iAreas && filterByList.SelectedIndices[0] < iAreas + 1 + Areas.Count())
                    Filter("Area", filterByList.SelectedItems[0].Text, false);
                //else
                    //Filter("Custom", filterByList.SelectedItems[0].Text, false);
            }
        }
    }
}