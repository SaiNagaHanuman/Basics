using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task_5
{
    class File_ArraysofStrings
    {
        static void Main()
        {
            {
                Console.WriteLine("Array size");
                int n = int.Parse(Console.ReadLine());
                string[] str = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"string {i + 1}");
                    str[i] = Console.ReadLine();
                }
                string filename = "output.txt";
                File.WriteAllLines(filename, str);
                Console.WriteLine("The File Was Created Successfully");
                Console.Read();

            }
        }
    }
}
