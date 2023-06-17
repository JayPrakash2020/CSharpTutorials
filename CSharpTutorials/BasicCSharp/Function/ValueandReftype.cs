using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Function
{
    public class ValueandReftype
    {
        public void Showdata(int num)
        {
            num *= num;
            Console.WriteLine("Value is " + num);
        }
        public void Showdataref(ref int num)
        {
            num *= num;
            Console.WriteLine("Value is " + num);
        }
    }
}
