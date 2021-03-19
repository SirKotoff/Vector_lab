using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vector_lab
{
    class Program
    {
        static void Main(string[] args)
        {

            string path2 = "Inlet.in";    //файл для ввода данных 
            string path1 = "Outlet.out";  //файл для вывода данных

            string content = "1 0 2 0 4 0 0 8 9 0 1 9 7";
            File.WriteAllText(path2, content); // записываем данные в файл inlet.in
            char[] arr = File.ReadAllText(path2).ToCharArray(); //записываем данные из intlet.out в массив

            int i = 0; // счётчик

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != '0')
                {
                    arr[i++] = arr[j];
                }
            }

            while (i < arr.Length)
            {
                arr[i++] = '0';
            }

            string d = "";
            for (int a = 0; a < arr.Length - 1; a++)
            {
                d += arr[a].ToString();
                File.WriteAllText(path1, d); // записываем данные в файл outlet.out
                d = File.ReadAllText(path1).ToString().Replace(" ", String.Empty); //считываем данные из файла и удаляем лишние пробелы


            }


            foreach (var p in d)
            {
                Console.WriteLine(p);  //вывод строки на экран 
            }









            Console.ReadKey();






        }
    }
}
