using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream_02
{
    class Program
    {//Произвольный доступ к файлам
        static void Main(string[] args)
        {
            string text = "hello world";
            using (FileStream fstream=new FileStream(@"D:\apache\test.txt", FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(text);
                fstream.Write(input, 0, input.Length);
                Console.WriteLine("Текст записан в файл");

                // перемещаем указатель в конец файла, до конца файла- пять байт
                fstream.Seek(-5, SeekOrigin.End);// минус 5 символов с конца потока
                // считываем четыре символов с текущей позиции
                byte[] output = new byte[4];
                fstream.Read(output, 0, output.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine("Текст из файла: {0}", textFromFile); // worl

                // заменим в файле слово world на слово house

                string replaceText = "house";
                fstream.Seek(-5, SeekOrigin.End);
                input = Encoding.Default.GetBytes(replaceText);
                fstream.Write(input, 0, input.Length);
                // считываем весь файл
                // возвращаем указатель в начало файла
                fstream.Seek(0, SeekOrigin.Begin);
                output = new byte[fstream.Length];
                textFromFile = Encoding.Default.GetString(output);


                Console.WriteLine("Текст из файла: {0}", textFromFile); // hello house

                //Закрытие потока
                FileStream fstream1 = null;
                try
                {
                    fstream1 = new FileStream(@"D:\apache\test.txt", FileMode.OpenOrCreate);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    if (fstream1 != null)
                        fstream1.Close();
                }

            }



            Console.ReadLine();
        }
    }
}
