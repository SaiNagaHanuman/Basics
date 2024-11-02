using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program5
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 82, 84, 83, 85, 90, 100, 87, 89, 99, 91 };
            int total = 0;
            Console.WriteLine("The Total is");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                total += a[i];
            }
            Console.WriteLine(total);
            Console.ReadLine();
            Console.WriteLine("The Average is");
            int size = a.Length;
            int avg = (total / size);
            Console.WriteLine(avg);
            Console.ReadLine();
            Console.WriteLine("The Minimum Marks is");
            int min = a[0];
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine(min);
            Console.ReadLine();
            Console.WriteLine("The Maximum Marks is");
            int max = a[0];
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine(max);
            Console.Read();
            Array.Sort(a);
            Console.WriteLine("Array in Asscending order is");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);

            }
            Console.ReadLine();
            Array.Reverse(a);
            Console.ReadLine();
            Console.WriteLine("Array in Descending order is");
            foreach (int rev in a)
            {
                Console.WriteLine(rev);

            }
            Console.ReadLine();

        }
    }
}
