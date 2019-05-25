using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDirectory_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"D:\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Subdirectory");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Files");
                string[] files = Directory.GetFiles(dirName);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }


            //Create Directory
            string path = @"D:\SomeDir";
            string subPath = @"D:\program\avalon";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if(!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            dirInfo.CreateSubdirectory(subPath);
            Console.ReadLine();
        }
    }
}
