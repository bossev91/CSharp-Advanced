using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> fileList = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo("C:/Windows/System32"); //  Put what you want .
            FileInfo[] files = directoryInfo.GetFiles();
            StreamWriter report = new StreamWriter("../../../report.txt");


            foreach (var file in files)
            {
                if(!fileList.ContainsKey(file.Extension))
                {
                    fileList.Add(file.Extension, new Dictionary<string, double>());
                }
                fileList[file.Extension].Add(file.Name, file.Length / 1000.00);
            }

            foreach (var list in fileList.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                report.WriteLine(list.Key);
                {
                    foreach (var item in list.Value.OrderBy(x => x.Value))
                    {
                        report.WriteLine($"--{item.Key} - {item.Value}kb");
                    }
                }
            }

        }
    }
}
