using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Looping
{
    public class NestedLoop
    {
        private int row, col,colspace;

        public void Pattern1()
        {
            Console.WriteLine("Pattern 1 is below");
            for(row =  1; row <= 5; row++)     //
            {
                for(col= 1; col <= row; col++) //
                {
                    Console.Write("* ");  // *
                }
                Console.WriteLine();
            }
        }

        public void Pattern2()
        {
            Console.WriteLine("Pattern 1 is below");
            for (row = 1; row <= 5; row++)     //
            {
                for (col = 1; col <= row; col++) //
                {
                    Console.Write(col);  // *
                }
                Console.WriteLine();
            }
        }

        public void Pattern3()
        {
            Console.WriteLine("Pattern 1 is below");
            for (row = 1; row <= 5; row++)     //
            {
                for (col = 1; col <= row; col++) //
                {
                    Console.Write(row);  // *
                }
                Console.WriteLine();
            }
        }


        public void Pattern4()
        {
            Console.WriteLine("Pattern 1 is below");
            for (row = 5; row >= 1; row--)     //
            {
                for (col = 1; col <= row; col++) //
                {
                    Console.Write("* ");  // *
                }
                Console.WriteLine();
            }
        }

        public void Pattern5()
        {
            Console.WriteLine("Pattern 1 is below");
            for (row = 5; row >= 1; row--)     //
            {
                for (col = 5; col >= row; col--) // 5,54,543,5432,54321
                {
                    Console.Write(col);  // 
                }
                for(col = 1; col <= row-1; col++)
                {
                    Console.Write(row); //5555,444,33,2
                }
                Console.WriteLine();
            }
        }
        public void Pattern6()
        {
            Console.WriteLine("Pattern 1 is below");
            for (row = 1; row <=5; row++)     //
            {
                for (colspace = 1; colspace <= 5-row; colspace++) // 5,54,543,5432,54321
                {
                    Console.Write(" ");  // 
                }
                for (col = 1; col <= row; col++)
                {
                    Console.Write("* "); //5555,444,33,2
                }
                Console.WriteLine();
            }
        }

        public void Pattern7()
        {
            Console.WriteLine("Pattern 1 is below");
            for (row = 1; row <= 9; row++)     //
            {
                if (row <= 5)
                {
                    for (colspace = 1; colspace <= 5 - row; colspace++) // 5,54,543,5432,54321
                    {
                        Console.Write(" ");  // 
                    }
                    for (col = 1; col <= row; col++)
                    {
                        Console.Write("* "); //5555,444,33,2
                    }
                    Console.WriteLine();
                }
                else 
                {
                    for (colspace = 6; colspace <= row; colspace++) // 5,54,543,5432,54321
                    {
                        Console.Write(" ");  // 
                    }
                    for (col = 1; col <= row; col++)
                    {
                        Console.Write("* "); //5555,444,33,2
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
