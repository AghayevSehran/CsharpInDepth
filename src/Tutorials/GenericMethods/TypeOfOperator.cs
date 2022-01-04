using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    internal class TypeOfOperator
    {
        public static void PrintType<T>()
        {
            Console.WriteLine("typeof(T) ={0}", typeof(T));
            Console.WriteLine("typeof(List<T>) ={0}", typeof(List<T>));
        }
    }
}
