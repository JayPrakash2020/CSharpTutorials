using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ExceptionHandling
{
    public class Trycatchdemo
    {
        public void Progrmademo()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Finally Code is Working ");
            }
            Console.WriteLine("Code is working");
        }
    }
}
