using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ClassObject
{
    public class PropertyExample
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            { 
                name = value+" Udeshatechworld";
            }
        }

        public void EmployeeDetails()
        {
            Name = "Abhishek SIngh";
            Console.WriteLine("Name is "+Name);
        }
    }
}
