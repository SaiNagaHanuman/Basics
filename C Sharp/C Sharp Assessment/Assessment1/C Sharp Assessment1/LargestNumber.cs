using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assessment1
{
    class LargestNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the first integer:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third integer:");
            int third = Convert.ToInt32(Console.ReadLine());

            int largestNum = Find(first, second, third);

            Console.WriteLine("Largest among all three integers is: " + largestNum);
            Console.Read();
        }

        static int Find(int a, int b, int c)
        {
            int largest = a;

            if (b > largest)
            {
                largest = b;
            }

            if (c > largest)
            {
                largest = c;
            }
            return largest;
        }
    }
}
