using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_.Net
{
    class Program3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter The 1st Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The VALUE");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter The 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine("The Addition of " + a + " and " + b + " = " + (a + b));
                    Console.Read();
                    break;
                case '-':
                    Console.WriteLine("The Substraction of " + a + " and " + b + " = " + (a - b));
                    Console.Read();
                    break;
                case '/':
                    Console.WriteLine("The Division of " + a + " and " + b + " = " + (a / b));
                    Console.Read();
                    break;
                case '*':
                    Console.WriteLine("The Multiplication of " + a + " and " + b + " = " + (a * b));
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("TYPE THE INVALID VALUE");
                    break;
            }
            Console.Read();
        }
    }
}
