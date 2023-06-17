using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ArrayFunction
{
    public class ArrayFunctions
    {

        private int[] array=new int[13];
        private int i, sh;
        private int[] arr = new int[13] { 52, 54, 6, 25, 45, 25, 63, 47, 65, 25, 36, 7, -6 };
        private int[] arr1 = new int[13] { -6, 2, 6, 12, 15, 23, 29, 34, 38, 61, 72, 87, 93 };

        public void Arraylenght()
        {
            sh = arr.Length;
            Console.WriteLine("Length is " +sh);
        }
        public void Print1DArray(int[] arr123)
        {
            Console.WriteLine("\nPrinting Array elements are below");
             for(i = 0; i < arr123.Length; i++)
            {
                Console.Write(arr123[i]+"\t");
            }
        }
        public void Print1DArrayParam(params int[] arr123)
        {
            Console.WriteLine("\nPrinting Array elements are below");
            for (i = 0; i < arr123.Length; i++)
            {
                Console.Write(arr123[i] + "\t");
            }
        }
        public void Print1DArrayParamDiffType(params object[] arr123)
        {
            Console.WriteLine("\nPrinting Array elements are below");
            for (i = 0; i < arr123.Length; i++)
            {
                Console.Write(arr123[i] + "\t");
            }
        }
        public void PassingArray()
        {
            Print1DArray(arr);
            array = arr1;
            Console.WriteLine("\nNew Array is ");
            Print1DArray(array);
            Print1DArrayParam(15,52,36,45,25,36,54,96,45);
            Print1DArrayParamDiffType("Jay Prakash",34,989.52,"Abhishek","Satya","Aviansh",875.25d);
        }

        public void ArraySorting()
        {
            Console.WriteLine("\nArray Before Sorting ");
            Print1DArray(arr);
            Array.Sort(arr);
            Console.WriteLine("\nArray After Sorting ");
            Print1DArray(arr);

        }
        public void ArrayCoping()
        {
            Array.Copy(arr,array,arr.Length);
            Print1DArray(array);
        }
        public void ArrayReverse()
        {
            Console.WriteLine("\nOrignal Array ");
            Print1DArray(arr);
            Array.Reverse(arr);
            Console.WriteLine("\n After Reversing Array");
            Print1DArray(arr);

        }
    }
}
