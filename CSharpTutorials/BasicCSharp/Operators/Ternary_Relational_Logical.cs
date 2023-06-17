using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Operators
{
    public class Ternary_Relational_Logical
    {
        private int age;
        private string result;
        public void VotingAge()
        {
            Console.WriteLine("Enter your age");
            age=Convert.ToInt32(Console.ReadLine());
            result = (age >= 18) ? "You are eligible to Vote" : " Sorry,You are not eligilbe to Vote";

            Console.WriteLine(result);
        }

        public void ValidAge()
        {
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            result = (age >= 1 && age<=150) ? "You Age is Valid" : " Sorry,You have enterd Invalid Age";

            Console.WriteLine(result);
        }
    }
}
