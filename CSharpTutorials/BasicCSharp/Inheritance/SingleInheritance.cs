using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Inheritance
{
    public class SingleInheritance
    {
        public float salary = 20000;
    }
    public class Programmer : SingleInheritance
    {
        public float bonus = 5000;
    }
    public class Designer : SingleInheritance
    {
        public float bonus = 2800;
    }
    public class Employee
     {

        public void EmployeeSalaryDetails()
        {
            Programmer p = new Programmer();
            Console.WriteLine("Programmer Salary is " + p.salary);
            Console.WriteLine("Programmer Bonus is " + p.bonus);
            Designer d= new Designer();
            Console.WriteLine("Designer Salary is " + d.salary);
            Console.WriteLine("Designer Bonus is " + d.bonus);
        }
     }
}

