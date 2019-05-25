using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterReader_02
//Запись в файл и StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string readPath = @"D:\apache\test.txt";
            string writePath = @"D:\apache\testW.txt";
            string text = "";
            try
            {
                using (StreamReader sr=new StreamReader(readPath, Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }

                using(StreamWriter sw=new StreamWriter(writePath, false, Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                using(StreamWriter sw=new StreamWriter(writePath, true, Encoding.Default))
                {
                    sw.WriteLine("Dozapisa");
                    sw.WriteLine(4.5);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message) ;
            }



            Console.ReadLine();
        }
    }
}
