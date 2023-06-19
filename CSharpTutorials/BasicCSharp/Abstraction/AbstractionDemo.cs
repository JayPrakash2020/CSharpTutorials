using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Abstraction
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class Rectange : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectange ..");
        }
    }

    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle ..");
        }
    }
    public class AbstractionDemo : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Showing Abstraction Demo ..");
        }
    }
}
