using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_.Net
{
    class Program
    {
        public static void Main()
        {
           Console.WriteLine(" The first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine(" The second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
 
            int sum = num1 + num2;
 
            if(num1 == num2)
            {
                sum*= 3;
            }
 
            Console.WriteLine($"Sum is {sum}");
            Console.Read();
        }
    }
}
