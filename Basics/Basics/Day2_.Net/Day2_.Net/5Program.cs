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
            Console.WriteLine("Enter The Input 1st Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Input 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != b) Console.WriteLine(a + b);
            else Console.WriteLine(3 * (a + b));
            Console.Read();
        }
    }
}
