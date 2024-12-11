using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employees
{
    public class Employees
    {
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Employees> empList = new List<Employees>
           {
               new Employees { EmpID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
               new Employees { EmpID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
               new Employees { EmpID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
               new Employees { EmpID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
               new Employees { EmpID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
               new Employees { EmpID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
               new Employees { EmpID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
               new Employees { EmpID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
               new Employees { EmpID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
               new Employees { EmpID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
           };

            //1. Employees who joined before 1/1/2015
         
            Console.WriteLine("Employees who joined before 1/1/2015:");
            var joinedBefore2015 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));
            foreach (var emp in joinedBefore2015)
                Console.WriteLine($"{emp.EmpID} - {emp.FirstName} {emp.LastName}");

            // 2. Employees whose DOB is after 1/1/1990
          
            Console.WriteLine("\nEmployees whose DOB is after 1/1/1990:");
            var bornAfter1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));
            foreach (var emp in bornAfter1990)
                Console.WriteLine($"{emp.EmpID} - {emp.FirstName} {emp.LastName}");

            // 3. Employees whose designation is Consultant or Associate

            Console.WriteLine("\nEmployees with designation Consultant or Associate:");
            var consultantOrAssociate = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            foreach (var emp in consultantOrAssociate)
                Console.WriteLine($"{emp.EmpID} - {emp.FirstName} {emp.LastName}");

            // 4. Total number of employees

            Console.WriteLine($"\nTotal number of employees: " +
                $"{empList.Count}");

            // 5. Total number of employees belonging to “Chennai”

            Console.WriteLine($"\nTotal number of employees in Chennai: " +
                $"{empList.Count(e => e.City == "Chennai")}");
            
            // 6. Highest Employee ID

            Console.WriteLine($"\nHighest Employee ID: " +
                $"{empList.Max(e => e.EmpID)}");
           
            // 7. Employees who joined after 1/1/2015

            Console.WriteLine($"\nEmployees who joined after 1/1/2015: " +
                $"{empList.Count(e => e.DOJ > new DateTime(2015, 1, 1))}");
            
            // 8. Employees whose designation is not “Associate”

            Console.WriteLine($"\nEmployees whose designation is not 'Associate':" +
                $" {empList.Count(e => e.Title != "Associate")}");
           
            // 9. Total number of employees based on City

            Console.WriteLine("\nEmployee count by City:");
            var employeesByCity = empList.GroupBy(e => e.City);
            foreach (var group in employeesByCity)
                Console.WriteLine($"{group.Key}: {group.Count()}");
           
            // 10. Total number of employees based on City and Title

            Console.WriteLine("\nEmployee count by City and Title:");
            var employeesByCityAndTitle = empList.GroupBy(e => new { e.City, e.Title });
            foreach (var group in employeesByCityAndTitle)
                Console.WriteLine($"{group.Key.City} - {group.Key.Title}: {group.Count()}");
           
            // 11. Youngest employee in the list

            var youngestEmployee = empList.OrderByDescending(e => e.DOB).First();
            Console.WriteLine($"\nYoungest Employee: {youngestEmployee.FirstName} {youngestEmployee.LastName}, " +
                $"DOB: {youngestEmployee.DOB.ToShortDateString()}");
            Console.Read();
        }
    }
}
