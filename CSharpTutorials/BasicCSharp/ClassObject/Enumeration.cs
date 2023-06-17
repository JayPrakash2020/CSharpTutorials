using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ClassObject
{
    public class Enumeration
    {
        public enum Option
        {
            Addition=52,

            Subtraction=15,
            Multiplication=77,
            Division=135
        }

        public void CallEnum()
        {
            foreach(string s in Enum.GetNames(typeof(Option)))
            {
                Console.WriteLine("Enum value is " +s);
            }
        }
            
    }
}
