using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Exception_NegativeNoS
    {
        static void CheckNumber(int num)
        {
            if (num < 0)
                throw new ArgumentException("The Number was not be negative.");
            else
                Console.WriteLine($"The number is: {num}");
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the Number:");
                int number = Convert.ToInt32(Console.ReadLine());
                CheckNumber(number);
            }
            catch (ArgumentException q)
            {
                Console.WriteLine("The Error Occured :" + q.Message);
            }
            catch (FormatException q)
            {
                Console.WriteLine("Invalid input.&. Enter a valid number" +q.Message);
            }
            Console.ReadLine();

        }
    }
}
