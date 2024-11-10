
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class IstudentInterface
    {
        interface Student
        {
            int studentId { get; set; }
            String Name { get; set; }
            void ShowDetails();

        }
        class Dayscholar : Student
        {
            public int studentId { get; set; }
            public String Name { get; set; }
            public int Line
            {
                get
                {
                    return studentId;
                }
                set
                {
                    studentId = value;
                }
            }
            public String Lines
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }

            }
            public void ShowDetails()
            {
                Console.WriteLine("Dayscholar class:");
                Console.WriteLine("The Student id is:" + studentId);
                Console.WriteLine("The Student name is:" + Name);
            }
        }
        public class Resident : Student
        {
            public int studentId { get; set; }
            public String Name { get; set; }
            public int Line
            {
                get
                {
                    return studentId;
                }
                set
                {
                    studentId = value;
                }
            }
            public String student
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }
            }
            public void ShowDetails()
            {
                Console.WriteLine("Resident class:");
                Console.WriteLine("The student id is:" + studentId);
                Console.WriteLine("The Name is:" + Name);

            }
            public static void Main(String[] args)
            {

                Resident r = new Resident();
                Console.WriteLine("Enter the studentId of Resident class");
                r.Line = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the student name of Resident class:");
                r.student = (Console.ReadLine());
                r.ShowDetails();
                Dayscholar d = new Dayscholar();
                Console.WriteLine("Enter the Studentid in dayscholar class:");
                d.Line = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Studentid in dayscholar class:");
                d.Lines = (Console.ReadLine());
                d.ShowDetails();
                Console.Read();
            }
        }
    }
}
