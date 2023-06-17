using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ArrayFunction
{
    public class _1DArray
    {
        private int[] array;
        private int i,sh;
        private int[] arr=new int[13] { 52,54,6,25,45,25,63,47,65,25,36,7,-6};
        private int[] arr1 = new int[13] { -6,2,6,12,15,23,29,34,38,61,72,87,93 };
        public void ArrayProgram1()
        {
            array = new int[10];
            Console.WriteLine("Enter 10 numbers");
            for(i=0;i<10;i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Stored Numbers are");
            for (i = 0; i < 10; i++)
            {
               Console.Write(array[i]+"\t");
            }
        }
        public void ArrayProgram2()
        {
            int sum = 0;
            array = new int[10];
            Console.WriteLine("Enter 10 numbers");
            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Stored Numbers are");
            for (i = 0; i < 10; i++)
            {
                sum=sum+array[i];
            }
            Console.Write("Sum of All Numbers in an Array is "+sum);
        }

        public void ArrayProgram3()
        {
            int sum = 0;
            array = new int[10];
            Console.WriteLine("Enter 10 numbers");
            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                if (array[i]%2==0)
                  sum = sum + array[i];
            }
            Console.Write("Sum of All Even Numbers in an Array is " + sum);
        }

        public void LinearSearch()
        {
            int found = 0;
            Console.WriteLine("Enter a number which you want to search");
            sh = Convert.ToInt32(Console.ReadLine());

            for(i=0;i<arr.Length;i++)
            {
                if (sh == arr[i])
                {
                   found = 1;
                    break;
                }
            }
             if(found==1)
                Console.WriteLine("Number found at "+(i+1)+" Position");
             else
                Console.WriteLine("Number NOt found " );
        }
        public void BinarySearch()
        {
            int found = 0;
            int max = arr1.Length;
            int min = 0;
            int mid = 0;
            Console.WriteLine("Enter a number which you want to search");
            sh = Convert.ToInt32(Console.ReadLine());

          
                while (min <= max-1)
                {
                    mid = (min + max) / 2;
                    if (sh == arr1[mid])
                    {
                        found = 1;
                        break;
                    }
                    else if (sh > arr1[mid])
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        max = mid - 1;
                    }
                }
            
            if (found == 1)
                Console.WriteLine("Number found at " + (mid) + " Position");
            else
                Console.WriteLine("Number NOt found ");
        }
    }
}
