using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Polymorphism
{

    
    public class Overriding
    {
        public virtual void Msg()
        {
            Console.WriteLine("Eating Bread .... is good for Health");
        }
    }
    public class Party:Overriding
    {
        public override void Msg()
        {
            Console.WriteLine("Eating Pizza and Coldding.... is what we want in Party");
        }
    }
}
