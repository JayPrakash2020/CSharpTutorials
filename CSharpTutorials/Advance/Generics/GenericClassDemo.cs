using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials.Advance.Generics
{
    public class GenericClassDemo<T>
    {
       public GenericClassDemo(T message)
        {
            Console.WriteLine(message);
        }

        private T[] array;

        public GenericClassDemo(int size)
        {
            array = new T[size+1];
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }
}
