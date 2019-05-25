using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your wish for writing...");
            string text = Console.ReadLine();
            // запись в файл
            using (FileStream fstream = new FileStream(@"D:\apache\test.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }

            Console.WriteLine("чтение из файла");
            // чтение из файла
            using (FileStream fstream = File.OpenRead(@"D:\apache\test.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(array);
                Console.WriteLine("Текст из файла: {0}", textFromFile);
            }

            Console.ReadLine();

        }
    }
}
