using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_.Net
{
    class _4Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Multiplication table ");
            Console.Write("Enter value :");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
            Console.Read();
        }
    }
}
