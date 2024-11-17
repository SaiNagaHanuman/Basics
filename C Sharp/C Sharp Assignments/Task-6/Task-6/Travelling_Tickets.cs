using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Travelling_Tickets
    {
        public void calculatesconcession(string name, int age)
        {
            const int TotalFare = 500;
            int fare = TotalFare - (TotalFare * 30) / 100;

            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                Console.WriteLine("Senior Citizen" + " " + "Calculated Fare:" + fare);
            }
            else
            {
                Console.WriteLine($"Ticket Booked" + TotalFare);
            }
        }
    }
}
