using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class Text_File
    {
        static void Main()
        {
            string filePath = "C:\\Infinite.net\\C Sharp\\C Sharp Assessment\\Assessment3\\Code - 3.txt";
            Console.Write("Enter the text to append: ");
            string text = Console.ReadLine();

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(text);
            }

            Console.WriteLine("The Text appended Added Successfully.");
            Console.WriteLine("Appended text:");
            Console.WriteLine(File.ReadAllText(filePath));
            Console.ReadLine();
        }
    }
}

