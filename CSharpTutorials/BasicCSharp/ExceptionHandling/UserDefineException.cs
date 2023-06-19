using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.BasicCSharp.ExceptionHandling
{
    public class UserDefineException:Exception
    {
        public UserDefineException(String message):base(message)
        {

        }
    }

    public class ExceptionDemo
    {
        public void check()
        {
            throw new UserDefineException("Sorry Issue is present");
        }
    }
}
