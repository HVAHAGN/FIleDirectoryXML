using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\apache\test.txt";
            try
            {
                Console.WriteLine("******считываем весь файл********");
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    
                }
                Console.WriteLine();
                Console.WriteLine("******считываем построчно********");
                using (StreamReader sr=new StreamReader(path, Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("******считываем блоками********");
                using(StreamReader sr=new StreamReader(path, Encoding.Default))
                {
                    char[] array = new char[4];
                    sr.Read(array, 0, 4);
                    Console.WriteLine(array);
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadLine();
        }
    }
}
