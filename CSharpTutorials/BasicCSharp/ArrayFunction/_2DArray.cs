using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ArrayFunction
{
    public class _2DArray
    {
        private int[,] array;
        private int i, j;
        public void ArrayProgram1()
        {
            array = new int[3,3];
            Console.WriteLine("Enter 9 numbers");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Stored Numbers are");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j]+"\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
