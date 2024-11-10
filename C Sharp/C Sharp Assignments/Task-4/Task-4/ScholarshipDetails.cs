using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
   
        class marksException : ApplicationException
        {
            public marksException(String msg) : base(msg)
            {

            }
        }
        class ScholarshipDetails
        {
            public delegate int MeritMarks(int marks, int fees);
            public static int Merit(int marks, int fees, MeritMarks mm)
            {
                return mm(marks, fees);
            }
            public static void getMarks(int marks)
            {
                if (marks > 100)
                {
                    throw (new marksException("enter marks between 0 and 100"));
                }

            }
            public static int scholarship_amount(int marks, int fees)
            {
                if (marks >= 70 && marks <= 80)
                {
                    return (fees * 20) / 100;
                }
                else if (marks > 80 && marks <= 90)
                {
                    return (fees * 30) / 100;
                }
                else if (marks > 90)
                {
                    return (fees * 50) / 100;
                }
                return 0;
            }
        }
        class DetailsofScholarship
    {
            static void Main()
            {
                Console.WriteLine("enter Marks");

                int marks = int.Parse(Console.ReadLine());
                try
                {
                    ScholarshipDetails.getMarks(marks);
                }
                catch (marksException me)
                {
                    Console.WriteLine(me.Message);
                }
                Console.WriteLine("Enter fees");
                int fees = int.Parse(Console.ReadLine());
                int amount = ScholarshipDetails.Merit(marks, fees, ScholarshipDetails.scholarship_amount);
                Console.WriteLine(amount);
                Console.ReadLine();
            }
        }
}
