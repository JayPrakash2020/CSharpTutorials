using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.Advance.Collection
{
    public class HashSetClass
    {
        public void HashSetDemo()
        {
            var program=new HashSet<string>() { "Java", "C#", "VB", "PHP", "Python", "Node" };

            foreach (var pro in program)
            {
                Console.WriteLine(pro);
            }

            program.Remove("C#");

            Console.WriteLine("After Removing Value ");
            foreach (var pro in program)
            {
                Console.WriteLine(pro);
            }

          

        }

        public void RemoveDuplicateCharacter()
        {
            string str = "Jay Prakash Pathak";

            Console.WriteLine("Initial String is " +str);

            var unique=new HashSet<char>(str);
            Console.WriteLine("After Removing Duplicate Values " );
            foreach(char ch in unique)
            {
                Console.Write(ch);
            }
           
        }
    }
}
