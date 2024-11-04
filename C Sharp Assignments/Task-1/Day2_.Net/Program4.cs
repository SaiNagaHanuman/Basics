using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_.Net
{
    class Program4
    {
  
        static void Main(string[] args)
        {
            Console.WriteLine(" Multiplication table ");
            Console.Write("Enter value :");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine($"{c} * {i} = {c* i}");
                Console.Read();
            }
        }
    }

}

