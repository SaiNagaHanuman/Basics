using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3 
{
    class String_lengthProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string Input = Console.ReadLine();

            int length = Input.Length;

            Console.WriteLine("The length of the word is: " + length);
            Console.ReadLine();
        }
    }
}
