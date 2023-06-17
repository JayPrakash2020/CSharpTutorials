using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Inheritance
{
    public class Details
    {
        public string Name = "Abhishek SIngh";
        public string Address = "Ranchi";
        public int age = 25;
        public void BasicDetails()
        {
            Console.WriteLine("Name is \t"+Name);
            Console.WriteLine("Address is \t" + Address);
            Console.WriteLine("Age is \t\t" + age);
        }
    }
    public class Employees:Details
    {
        public string Department = "IT";
        public string Designation = "Team Lead";
        public void EmployeeDetails()
        {
            Console.WriteLine("Department is \t" + Department);
            Console.WriteLine("Designation is \t" + Designation);
        }
    }

    public class Bonus:Employees
    {
        public double salary = 14500;
        public void BonusDetails()
        {
            Console.WriteLine("Salary is \t" + salary);
            Console.WriteLine("Bonus is \t"+(salary*0.15));
        }
    }
    
}
