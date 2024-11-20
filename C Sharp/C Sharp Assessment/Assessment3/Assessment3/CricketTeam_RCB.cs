using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class CricketTeam_RCB
    {
        public string Team_Name { get; set; }
        public int Matches { get; set; }
        public int Sum { get; set; }
        public double Average { get; set; }

        public (int, int, double) PointsCalculation(int noofMatchesPlayed)
        {
            Sum = 0;
            for (int i = 0; i < noofMatchesPlayed; i++)
            {
                Console.Write($"Enter score for match {i + 1}:");
                Sum += Convert.ToInt32(Console.ReadLine());
            }
            Matches = noofMatchesPlayed;
            Average = (double)Sum / noofMatchesPlayed;
            return (Matches, Sum, Average);
        }
    }

    class Ipl
    {
        static void Main()
        {
            CricketTeam_RCB team = new CricketTeam_RCB();
            team.Team_Name = "Royal Challengers Bengaluru ";
            Console.Write("Enter number of matches Played in the Season : ");
            int noofMatchesPlayed = Convert.ToInt32(Console.ReadLine());
            var (matches, sum, average) = team.PointsCalculation(noofMatchesPlayed);
            Console.WriteLine($"Team: {team.Team_Name}, Matches: {matches}, Sum: {sum}, Average: {average}");
            Console.Read();
        }
    }
}