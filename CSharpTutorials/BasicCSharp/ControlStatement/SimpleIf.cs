using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ControlStatement
{
    public class SimpleIf
    {
        int age;

        public void VotingAge()
        {
            Console.WriteLine("Enter your age");
            age=Convert.ToInt32(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine("You are Eligible for Vote");
            }
        }
    }
}
