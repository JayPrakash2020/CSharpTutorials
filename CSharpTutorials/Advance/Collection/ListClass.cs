using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.Advance.Collection
{
    public class ListClass
    {
        public void ListDemo()
        {
            var list = new List<string>() { "Java","C#","VB","PHP","Python","NOde"};

            //list.Add("Java");
            //list.Add("C#");
            //list.Add("PHP");
            //list.Add("Python");
            //list.Add("VB");
            //list.Add("JScript");

            foreach(var program in list)
            {
                Console.WriteLine(program);
            }
        }
    }
}
