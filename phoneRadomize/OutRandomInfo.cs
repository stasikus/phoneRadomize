using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneRadomize
{
    public class OutRandomInfo
    {
        public static List<string> newListOne = new List<string>();
        public static List<string> newListTwo = new List<string>();

        public static void saveToInfo(string path, Panel p1)
        {
            Thread tr = new Thread(() => save(path, p1));
            tr.IsBackground = true;
            tr.Start();
        }
        
        public static void save(string path, Panel panel)
        {
            while (LoadList.newList.Count != 0)
            {
                Random r = new Random();
                int random = r.Next(0, LoadList.newList.Count);
                string s1 = LoadList.newList[random];
                LoadList.newList.RemoveAt(random);
                newListOne.Add(s1);
                Thread.Sleep(10);

            }
            while (newListOne.Count != 0)
            {
                Random r2 = new Random();
                int random2 = r2.Next(0, newListOne.Count);
                string s2 = newListOne[random2];
                newListOne.RemoveAt(random2);
                newListTwo.Add(s2);
            }

            string s;
            for (int i = 0; i < newListTwo.Count; i++)
            {
                StreamWriter sw = new StreamWriter(@"" + path + "\\out_phone_list.txt", true, System.Text.Encoding.UTF8);
                s = newListTwo[i];
                sw.WriteLine(s);
                sw.Close();
                s = "";
            }
            MessageBox.Show("Готово");

            panel.BeginInvoke((Action)delegate
            {
                panel.Enabled = true;
            });
        }
    }
}
