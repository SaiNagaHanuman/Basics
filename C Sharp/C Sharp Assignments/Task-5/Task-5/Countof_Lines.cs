using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Countof_Lines
    {
        static void Main()
        {
           // Console.WriteLine("Enter the Path of the File");
            string filePath = @"C: \Users\sainagag\Documents\file.txt";
            if (File.Exists(filePath))
            {
                 int count = File.ReadAllLines(filePath).Length;
                 Console.WriteLine("Lines {0}", count);   
            }
               Console.ReadLine();
        }
    }
}
