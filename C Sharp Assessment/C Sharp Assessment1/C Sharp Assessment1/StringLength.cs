using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assessment1
{
    class StringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the position to remove the letter:");
            int position = int.Parse(Console.ReadLine());

            if (position < 0 || position >= input.Length)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                string result = input.Remove(position, 1);
                Console.WriteLine("Result string: " + result);
                Console.ReadLine();
            }

        }
    }
}
