using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.Advance.Collection
{
    public class DictionaryClass
    {
        public void DictionaryDemo()
        {
            Dictionary<string, string> program = new Dictionary<string, string>();
            
            program.Add("1","Java");
            program.Add("2", "C#");
            program.Add("3", "C");
            program.Add("4", "C++");
            program.Add("5", "PHP");
            program.Add("6", "Python");
            program.Add("7", "Angular");

            foreach(KeyValuePair<string,string> kv in program )
            {
                Console.WriteLine(kv.Key +"   "+kv.Value);
            }
        }
    }
}
