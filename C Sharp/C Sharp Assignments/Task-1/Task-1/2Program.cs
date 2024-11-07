using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_.Net
{
    class program
    {
         static void Main()
        {
            Console.WriteLine("Enter The  Given Input  Number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine(" {0} is a Positive Number ",a);
            }
            else if (a < 0)
            {
                Console.WriteLine(" {0} is a Negative Number ",a);
            }
            Console.Read();
        }
    }
}
