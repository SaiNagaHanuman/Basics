using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class Class_Box
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Class_Box(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Class_Box operator +(Class_Box b1, Class_Box b2)
        {
            return new Class_Box(b1.Length + b2.Length, b1.Breadth + b2.Breadth);
        }
        public override string ToString()
        {
            return $"Length: {Length}, Breadth: {Breadth}";
        }
    }

    class Test_Class
    {
        public static void Main()
        {
            Console.Write("Enter length of ClassBox 1: ");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of ClassBox 1: ");
            int breadth1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter length of ClassBox 2: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of ClassBox 2: ");
            int breadth2 = Convert.ToInt32(Console.ReadLine());

            Class_Box ClassBox1 = new Class_Box(length1, breadth1);
            Class_Box ClassBox2 = new Class_Box(length2, breadth2);
            Class_Box ClassBox3 = ClassBox1 + ClassBox2;

            Console.WriteLine("ClassBox 1: " + ClassBox1);
            Console.WriteLine("ClassBox 2: " + ClassBox2);
            Console.WriteLine("ClassBox 3 Sum: " + ClassBox3);
            Console.ReadLine();
        }
    }
}
