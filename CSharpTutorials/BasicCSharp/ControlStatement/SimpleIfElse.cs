
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ControlStatement
{
    public class SimpleIfElse
    {
        private static int age;

        public static void VotingAge()
        {
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are Eligible for Vote");
            }
            else
            {
                Console.WriteLine("You are not eligible for Vote");
            }
        }
    }
}
