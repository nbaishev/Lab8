using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\C_sharp_projects";
            Console.WriteLine("Подкаталоги:");
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine();
            Console.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine();
            foreach (string dir in dirs)
            {
                Console.WriteLine("Подподкаталоги:");
                string[] subdirs = Directory.GetDirectories(dir);
                foreach (string subdir in subdirs)
                {
                    Console.WriteLine(subdir);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы в подкаталогах:");
                string[] subfiles = Directory.GetFiles(dir);
                foreach (string subfile in subfiles)
                {
                    Console.WriteLine(subfile);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
