using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDirectory_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"C:\Program Files";
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            Console.WriteLine("Name of directroy: {0}", dirInfo.Name);
            Console.WriteLine("Fullname of directory: {0}", dirInfo.FullName);
            Console.WriteLine("Time of creating directory: {0}", dirInfo.CreationTime);
            Console.WriteLine("Root of directory: {0}", dirInfo.Root);
            //Delete
            string dirName2 = @"D:\SomeDir";
            try
            {
                DirectoryInfo dirInf = new DirectoryInfo(dirName2);
                dirInf.Delete(true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //Move to directory
            string oldPath = @"D:\4. QA2";
            string newPath = @"D:\4. QA";
            DirectoryInfo dirInfo2 = new DirectoryInfo(oldPath);
            if(dirInfo2.Exists && Directory.Exists(newPath)==false)
            {
                dirInfo2.MoveTo(newPath);
            }

            Console.ReadLine();
        }
    }
}
