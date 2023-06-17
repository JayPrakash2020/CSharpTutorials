using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Looping
{
    public class FoorLoop
    {
        private int num, rem, res, loopCount;
        //wap to accept a number and reverse it using Do While
        public void ReverseNumber()
        {
            res = 0;
            Console.WriteLine("Enter your number");
            num = Convert.ToInt32(Console.ReadLine()); //452
            //452!=0 |45!=0 |4!=0 |0!=0
             for(; num != 0;num=num/10)
            { 
                rem = num % 10; //452%10=2  | 45%10=5 |4%10=4
                res = res * 10 + rem;//0*10+2=2 |2*10+5 =25 |25*10+4=254
            } 

            Console.WriteLine("After Reversing Number is " + res);
        }
        public void CheckPrimeNo()
        {
            Console.WriteLine("Enter your number");
            num = Convert.ToInt32(Console.ReadLine());
           for(loopCount = 2;loopCount < num;loopCount++)
            {
                if (num % loopCount == 0)
                    break;
            }

            if (num == loopCount || num == 1)
            {
                Console.WriteLine("Prime NO");
            }
            else
            {
                Console.WriteLine("Not Prime No");
            }
        }

    }
}
