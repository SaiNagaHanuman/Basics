using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 
{
    class Program1
    {
        static void Main(string[] args)
        {
            int number1 = 25, number2 = 20;

            Console.WriteLine($"Before swapping: number1 = {number1}, number2 = {number2}");
            Console.ReadLine();
            (number1, number2) = (number2, number1);

            Console.WriteLine($"After swapping: number1 = {number1}, number2 = {number2}");
            Console.ReadLine();
        }
    }
}
