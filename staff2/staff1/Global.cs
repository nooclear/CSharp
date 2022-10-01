using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace staff1
{
    class Global
    {
        public List<string> Sorts = new List<string>();
        public List<string> Areas = new List<string>();

        public void UpdateList(ListBox lbSort, ListBox lbArea)
        {
            if (File.Exists("sorts.txt") && File.Exists("areas.txt"))
            {
                foreach (string line in File.ReadAllLines("sorts.txt"))
                    Sorts.Add(line);
                foreach (string line in File.ReadAllLines("areas.txt"))
                    Areas.Add(line);
            }
            lbSort.Items.Add("--------------Shifts--------------");
            lbArea.Items.Add("--------------Areas--------------");
            foreach (string item in Sorts)
                lbSort.Items.Add(item);
            foreach (string item in Areas)
                lbArea.Items.Add(item);
        }

        public void ReturnMissingInfo(bool nameEmpty, bool sortEmpty, bool areaEmpty)
        {
            if (nameEmpty == true || sortEmpty == true || areaEmpty == true)
            {
                string[] missing = new string[3];
                if (nameEmpty == true)
                    missing[0] = "You must add a name";
                if (sortEmpty == true)
                    missing[1] = "You must select a shift";
                if (areaEmpty == true)
                    missing[2] = "You must select an area";
                string missing_Info = string.Format("You must have the following information filled out:\n\n{0}\n{1}\n{2}", missing[0], missing[1], missing[2]);
                MessageBox.Show(missing_Info);
            }
        }

        public void SendToPrinter(string File)
        {
            //Process Print = new Process();
            //Print.StartInfo.FileName = File;
            //Print.StartInfo.Verb = "Print";
            //Print.StartInfo.UseShellExecute = true;
            //Print.StartInfo.CreateNoWindow = true;
            //Print.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //Print.Start();
            //PrintDocument
        }
    }

    class CheckForExisting
    {
        File_Names file_names = new File_Names();
        public bool Single(string user)
        {
            List<string> users = new List<string>();
            using (StreamReader sr = new StreamReader(file_names.Users))
            {
                string js = sr.ReadToEnd();
                List<NE> emps = JsonConvert.DeserializeObject<List<NE>>(js);

                foreach (var item in emps)
                    users.Add(item.name.ToUpper().ToString());
                if (users.Contains(user.ToUpper()))
                {
                    string exists = string.Format("User already exists\n{0}", user);
                    MessageBox.Show(exists);
                    return true;
                }
                else
                    return false;
            }
        }

        public List<string> Multiple(ListBox.ObjectCollection objectCollection)
        {
            List<string> users = new List<string>();
            List<string> duplicates = new List<string>();
            List<string> upper = new List<string>();

            using (StreamReader sr = new StreamReader(file_names.Users))
            {
                string js = sr.ReadToEnd();
                List<NE> emps = JsonConvert.DeserializeObject<List<NE>>(js);
                foreach (var item in emps)
                    users.Add(item.name.ToString());
            }

            foreach (string item in objectCollection)
                upper.Add(item.ToUpper());

            foreach (string user in users)
            {
                if (upper.Contains(user.ToUpper()))
                    duplicates.Add(user);
            }
            return duplicates;
        }
    }

    class File_Names
    {
        public string Sorts = "sorts.txt";
        public string Areas = "areas.txt";
        public string Users = "j.json";
        public string Temp = "temp.txt";
    }

    class Directories
    {
        public string Logs = "logs";
        public string Exports = "exports";
    }

    class NE
    {
        public string name { get; set; }
        public string sort_name { get; set; }
        public string area { get; set; }
        public string start { get; set; }
        public string stop { get; set; }
    }
}
