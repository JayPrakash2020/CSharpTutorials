using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Abstraction
{
    public interface Drawable
    {
          void draw();
    }
    public class Square : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Square ..");
        }
    }

    public class Cone : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Cone ..");
        }
    }
    public class InterfaceDemo : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Interface Demo ..");
        }
    }
}
