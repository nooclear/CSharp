using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace staff1
{
    class DataFromWeb
    {
        public void f()
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
                if (Lines[i].Contains("<TD bgcolor=\"silver\"><strong>Total</strong></TD>"))
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
            foreach (string line in Data)
            {
                Final.Add(string.Concat(line.Where(Char.IsDigit)));
            }
        }
    }
}
