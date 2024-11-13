using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public abstract class Students_details
    {
        public string Name;
        public string StudentId;
        public double Grade;

        public Students_details(string name, string studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        public abstract string Passed();
    }

    public class Undergraduate : Students_details
    {
        public Undergraduate(string name, string studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        public override string Passed()
        {
            if (Grade > 70.0)
                return "Passed";
            else
                return "Failed";
        }
    }

    public class Graduated : Students_details
    {
        public Graduated(string name, string studentId, double grade)
            : base(name, studentId, grade)
        {
        }

        public override string Passed()
        {
            if (Grade > 80.0)
                return "Passed";
            else
                return "Failed";
        }
    }

    class Student_Grades
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The student is Undergraduated or The student is Graduated");
            string studentType = Console.ReadLine().Trim();

            if (studentType.Equals("Undergraduated", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEnter the Undergraduated Student Details:");

                Console.Write("Name: ");
                string undergradName = Console.ReadLine();

                Console.Write("Student ID: ");
                string undergradStudentId = Console.ReadLine();

                Console.Write("Grade: ");
                double undergradGrade = Convert.ToDouble(Console.ReadLine());

                Students_details undergrad = new Undergraduate(undergradName, undergradStudentId, undergradGrade);
                Console.WriteLine($"{undergrad.Name} {undergrad.Passed()} (Undergraduate)");
            }
            else if (studentType.Equals("Graduated", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nEnter the Graduate Student Details:");

                Console.Write("Name: ");
                string gradName = Console.ReadLine();

                Console.Write("Student ID: ");
                string gradStudentId = Console.ReadLine();

                Console.Write("Grade: ");
                double gradGrade = Convert.ToDouble(Console.ReadLine());

                Students_details grad = new Graduated(gradName, gradStudentId, gradGrade);
                Console.WriteLine($"{grad.Name} {grad.Passed()} (Graduated)");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter either 'Undergraduate' or 'Graduate'.");
                Console.ReadLine();
            }
        }
    }
}
