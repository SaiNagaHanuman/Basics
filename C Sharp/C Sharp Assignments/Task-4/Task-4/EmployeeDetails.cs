using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class EmployeeDetails
    {
        private int Empid;
        private string Empname;
        private float Salary;

        public int Employeid
        {
            get { return Empid; }
            set { Empid = value; }
        }
        public string Employeename
        {
            get { return Empname; }
            set { Empname = value; }
        }
        public float Employeesalary
        {
            get { return Salary; }
            set { Salary = value; }
        }
        public EmployeeDetails(int Empid, String Empname, float Salary)
        {
            this.Empid = Empid;
            this.Empname = Empname;
            this.Salary = Salary;
        }
        public void display()
        {
            Console.WriteLine($"Employee id   : {Empid}");
            Console.WriteLine($"Employee name : {Empname}");
            Console.WriteLine($"Salary  : {Salary}");
        }
    }
    class ParttimeEmployee : EmployeeDetails
    {
        private float wages;
        public float empwages
        {
            get { return wages; }
            set { wages = value; }
        }
        public ParttimeEmployee(int Empid, string Empname, float Salary, float wages) : base(Empid, Empname, Salary)
        {
            this.wages = wages;
        }
        public void displaywages()
        {
            base.display();
            Console.WriteLine($"wages  : {wages}");
        }
    }
    class Question4
    {
        static void Main()
        {
            Console.WriteLine("enter employee id");
            int empid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name");

            string empname = Console.ReadLine();
            Console.WriteLine("enter employee salary");

            float salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter employee wages");

            float wages = Convert.ToSingle(Console.ReadLine());
            ParttimeEmployee pe = new ParttimeEmployee(empid, empname, salary, wages);
            pe.displaywages();
            Console.Read();
        }
    }
}

