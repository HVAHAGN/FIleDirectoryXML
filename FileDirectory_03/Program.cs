using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileDirectory_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //File and FileInfo  Получение информации о файле
            string path = @"D:\4. QA\test.txt";
            FileInfo fileinf = new FileInfo(path);
            if (fileinf.Exists)
            {
                Console.WriteLine("File Name {0}", fileinf.Name);
                Console.WriteLine("Creation time {0}", fileinf.CreationTime);
                Console.WriteLine("Size {0}", fileinf.Length);
            }



            //Удаление файла

            if (fileinf.Exists)
            {
                fileinf.Delete();
            }

            //Перемещение файла
            string path2 = @"C:\apache\hta.txt";
            string newPath = @"C:\SomeDir\hta.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.MoveTo(newPath);
                // альтернатива с помощью класса File
                // File.Move(path, newPath);
            }

            //Копирование файла

            string path3= @"C:\apache\hta.txt";
            string newPath2= @"C:\Somedir\hta.txt";

            FileInfo file = new FileInfo(path3);
            if (file.Exists)
            {
                file.MoveTo(newPath2);
                //OR
                File.Copy(path2, newPath2, true);
            }



            Console.ReadLine();
        }
    }
}
