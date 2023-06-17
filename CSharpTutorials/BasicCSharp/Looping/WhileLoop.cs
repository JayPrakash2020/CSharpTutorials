using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Looping
{
    public class WhileLoop
    {
        private string name;
        private int loopCount,num,rem,res;
        
        public void DisplayName()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            loopCount = 1;
            while(loopCount<=10)//
            {
                Console.WriteLine("Name is " + name);
                loopCount++;
            }
            
        }

        public void DisplayNatural()
        {
            loopCount = 1;
            while (loopCount <= 10)//
            {
                Console.WriteLine(loopCount);
                loopCount++;
            }
        }

        public void DisplayEven()
        {
            loopCount = 2;
            while (loopCount <= 20)//
            {
                // if(loopCount%2==0)
                    Console.WriteLine(loopCount);
                loopCount=loopCount+2;
            }
        }

        //wap to accept a number and check whether it is Prime No or not

        public void CheckPrimeNo()
        {
            Console.WriteLine("Enter your number");
            num = Convert.ToInt32( Console.ReadLine());
            loopCount = 2;
            while (loopCount <num)
            {
                if (num % loopCount == 0)
                    break;
                loopCount++;
            }

            if (num == loopCount || num==1)
            {
                Console.WriteLine("Prime NO");
            }
            else
            {
                Console.WriteLine("Not Prime No");
            }
        }

        //wap to accept a number and reverse it
        public void ReverseNumber()
        {
            res = 0;
            Console.WriteLine("Enter your number");
            num = Convert.ToInt32(Console.ReadLine()); //452
            while (num!=0) //452!=0 |45!=0 |4!=0 |0!=0
            {
                rem = num % 10; //452%10=2  | 45%10=5 |4%10=4
                res = res * 10 + rem;//0*10+2=2 |2*10+5 =25 |25*10+4=254
                num = num / 10;//452/10=45 |45/10=4|4/10=0
            }
            Console.WriteLine("After Reversing Number is " + res);
           
        }
    }
}
