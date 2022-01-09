using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\C_sharp_projects\example.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            Random rnd = new Random();
            int S = 0;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(0, 11));
                }
            }

            using (StreamReader sw = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int num = Convert.ToInt32(sw.ReadLine());
                    //Console.WriteLine(num);
                    S+= num;
                }
            }

            Console.WriteLine("Сумма чисел в файле {0}", S);
            Console.ReadKey();
        }
    }
}
