using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Abstraction
{
    public class NameSpaceDemo
    {
        public void Msg()
        {
            Console.WriteLine("Hello WOrld ... ");
        }
    }
}

namespace demo1
{
    public class NameSpaceDemo
    {
        public void Msg()
        {
            Console.WriteLine("Hello World ... Namespace 1 ");
        }
    }
}

namespace demo2
{
    public class NameSpaceDemo
    {
        public void Msg()
        {
            Console.WriteLine("Hello World ...  Namespace 2");
        }
    }
}
