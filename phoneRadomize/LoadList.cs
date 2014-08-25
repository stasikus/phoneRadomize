using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneRadomize
{
    class LoadList
    {
        public static List<string> newList = new List<string>();

        public static void loadGroupList(string path)
        {
            newList = new List<string>();
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    newList.Add(sr.ReadLine());
                    if (newList.Contains(""))
                    {
                        newList = newList.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
                    }
                }
            }
        }
    }
}
