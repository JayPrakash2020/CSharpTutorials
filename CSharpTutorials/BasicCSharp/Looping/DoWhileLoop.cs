using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.Looping
{
    public class DoWhileLoop
    {
        private int num, rem, res;
        //wap to accept a number and reverse it using Do While
        public void ReverseNumber()
        {
            res = 0;
            Console.WriteLine("Enter your number");
            num = Convert.ToInt32(Console.ReadLine()); //452
            //452!=0 |45!=0 |4!=0 |0!=0
            do
            {
                rem = num % 10; //452%10=2  | 45%10=5 |4%10=4
                res = res * 10 + rem;//0*10+2=2 |2*10+5 =25 |25*10+4=254
                num = num / 10;//452/10=45 |45/10=4|4/10=0
            } while (num != 0);

             Console.WriteLine("After Reversing Number is " + res);
        }
    }
}
