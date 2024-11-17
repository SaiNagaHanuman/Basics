using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Tickets
    {
        public const int TotalFare = 500;
         void CalculateConcession()
        { 
            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int Age = Convert.ToInt32(Console.ReadLine());
            Tickets obj = new Tickets();
            obj.CalculateConcession();
            Console.Read();
        }
    }
}
