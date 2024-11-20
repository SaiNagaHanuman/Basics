using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    delegate int CalculatorDelegate(int A, int B);

    public class Calculator
    {
        public static int Addition(int A, int B) => A + B;
        public static int Subtraction(int A, int B) => A - B;
        public static int Multiplication(int A, int B) => A* B;

         public static void Main()
        {
            Console.Write("Enter the First Number: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number: ");
            int B = int.Parse(Console.ReadLine());

            CalculatorDelegate calcDelegate;

            calcDelegate = Addition;
            Console.WriteLine($"Addition: {calcDelegate(A, B)}");

            calcDelegate = Subtraction;
            Console.WriteLine($"Subtraction: {calcDelegate(A, B)}");

            calcDelegate = Multiplication;
            Console.WriteLine($"Multiplication: {calcDelegate(A, B)}");
            Console.Read();
        }
    }
}
