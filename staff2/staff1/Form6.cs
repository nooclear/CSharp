using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace staff1
{
    public partial class Form6 : Form
    {
        Form1 f1 = new Form1();
        private readonly Form1 _form1;
        public Form6(Form1  form1)
        {
            InitializeComponent();
            this._form1 = form1;
        }

        List<DateTime> Clicks = new List<DateTime>();
        DateTime NextClick = new DateTime();

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
            Rectangle Monitor = Screen.PrimaryScreen.Bounds;
            this.Width = Monitor.Width;
            dataGridView1.Width = Monitor.Width;
            dataGridView1.Height = 340;
            dataGridView1.Location = new Point(0, 44);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Width = (this.Width / dataGridView1.Columns.Count) - 2;

            for (int i = 0; i < 24; i++)
                hourSelect.Items.Add(i.ToString("00"));
            for (int i = 0; i < 60; i++)
                if (i.ToString().EndsWith("0") || i.ToString().EndsWith("5"))
                    minSelect.Items.Add(i.ToString("00"));
        }

        public void SetTimes()
        {
            if (dataGridView1.Rows.Count < 90)
                for (int i = 0; i < 96; i++)
                    dataGridView1.Rows.Add();

            int iHour = Convert.ToInt32(hourSelect.SelectedItem), iMin = Convert.ToInt32(minSelect.SelectedItem);

            dataGridView1.Rows[0].Cells[0].Value = hourSelect.SelectedItem.ToString() + ':' + (Convert.ToInt32(minSelect.SelectedItem) + 15).ToString();

            for (int i = 0; i < 96; i++)
            {
                iMin += 15;

                if (iMin >= 60)
                {
                    iHour++;
                    iMin = iMin - 60;
                }
                if (iHour > 23)
                    iHour = 0;
                dataGridView1.Rows[i].Cells[0].Value = iHour.ToString("00") + ':' + iMin.ToString("00");
                Clicks.Add(Convert.ToDateTime(iHour.ToString() + ':' + (iMin + 3).ToString()));
            }
        }

        public void CheckTime()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(DateTime.Now.ToString("mm")) >= 3 && Convert.ToInt32(DateTime.Now.ToString("mm")) <= 17)
                {
                    if (IsEmpty(i))
                    {
                        GetData(i);
                        break;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("mm")) >= 18 && Convert.ToInt32(DateTime.Now.ToString("mm")) <= 32)
                {
                    if (IsEmpty(i))
                    {
                        GetData(i);
                        break;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("mm")) >= 33 && Convert.ToInt32(DateTime.Now.ToString("mm")) <= 47)
                {
                    if (IsEmpty(i))
                    {
                        GetData(i);
                        break;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("mm")) >= 48 || Convert.ToInt32(DateTime.Now.ToString("mm")) <= 2)
                {
                    if (IsEmpty(i))
                    {
                        GetData(i);
                        break;
                    }
                }
            }
        }
        
        public void GetData(int desc)
        {
            WebClient client = new WebClient();
            string Month = DateTime.Now.ToString("MM");
            string Day = DateTime.Now.ToString("dd");
            string year = DateTime.Now.ToString("yy");
            string combo = Month + @"%2F" + Day + @"%2F" + year;
            //string Input = textBox1.Text;
            //byte[] raw = client.DownloadData(@"http://svrp000627ee/gss/Scor/BuildingSummary.asp?Date=" + combo + "&Sort=ALL&Accept=Accept");
            ////string webdata = Encoding.UTF8.GetString(raw);
            List<string> Lines = new List<string>();
            List<string> Data = new List<string>();
            //File.WriteAllText("temp.txt", Encoding.UTF8.GetString(raw));
            foreach (string line in File.ReadAllLines("temp.txt"))
                Lines.Add(line);
            for (int i = 0; i < Lines.Count; i++)
            {
                if(Lines[i].Contains("<TD bgcolor=\"silver\"><strong>Total</strong></TD>"))
                {
                    Data.Add(Lines[i + 1]);
                    Data.Add(Lines[i + 2]);
                    Data.Add(Lines[i + 3]);
                    Data.Add(Lines[i + 4]);
                    Data.Add(Lines[i + 6]);
                    Data.Add(Lines[i + 7]);
                    Data.Add(Lines[i + 8]);
                    Data.Add(Lines[i + 9]);
                    Data.Add(Lines[i + 10]);
                    Data.Add(Lines[i + 11]);
                    Data.Add(Lines[i + 12]);
                    Data.Add(Lines[i + 13]);
                    Data.Add(Lines[i + 14]);
                    Data.Add(Lines[i + 258]);
                }
            }
            List<string> Final = new List<string>();
            foreach(string line in Data)
            {
                Final.Add(string.Concat(line.Where(Char.IsDigit)));
            }
            for (int i = 0; i < Final.Count; i++)
                dataGridView1.Rows[desc].Cells[i+3].Value = Final[i];




            dataGridView1.Rows[desc].Cells[1].Value = f1.current_staffing + f1.current_newppl + f1.current_change;





            if (desc == 0)
                dataGridView1.Rows[desc].Cells[16].Value = Final[0];
            else
                dataGridView1.Rows[desc].Cells[16].Value = Convert.ToInt32(Final[0]) - Convert.ToInt32(dataGridView1.Rows[desc-1].Cells[16].Value);

            dataGridView1.Rows[desc].Cells[17].Value = Convert.ToInt32(Final[0]) - Convert.ToInt32(dataGridView1.Rows[desc].Cells[2].Value);

            dataGridView1.Rows[desc].Cells[19].Value = Final[13];

            if (desc == 0)
                dataGridView1.Rows[desc].Cells[18].Value = dataGridView1.Rows[desc].Cells[19].Value;
            else
                dataGridView1.Rows[desc].Cells[18].Value = Convert.ToInt32(dataGridView1.Rows[desc].Cells[19].Value) - Convert.ToInt32(dataGridView1.Rows[desc - 1].Cells[19].Value);


            //if (Convert.ToInt32(dataGridView1.Rows[desc].Cells[1].Value) >= 0)
            //{
            //    if (desc == 0)
            //        dataGridView1.Rows[desc].Cells[23].Value = Convert.ToInt32(dataGridView1.Rows[desc].Cells[1].Value) / 4;
            //    else
            //        dataGridView1.Rows[desc].Cells[23].Value = Convert.ToInt32(dataGridView1.Rows[desc].Cells[3].Value) / ((Convert.ToInt32(dataGridView1.Rows[desc].Cells[1].Value) / 4) + Convert.ToInt32(dataGridView1.Rows[desc - 1].Cells[23].Value));
            //}
        }

        bool IsEmpty(int Spot)
        {
            if (Convert.ToString(dataGridView1.Rows[Spot].Cells[1].Value) == "")
                return true;
            else
                return false;
        }
        

        private void Label1_Click(object sender, EventArgs e)
        {
            DataFromWeb dfw = new DataFromWeb();
            dfw.f();
            SetTimes();
            CheckTime();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
