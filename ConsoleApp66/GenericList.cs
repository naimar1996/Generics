using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    public class GenericList<T>
    {
        //public void Generic(T item)
        //{
        //    Console.WriteLine(item);
        //}

        
        public string SwapList( T value1, T value2)
        {
            T temp;
           temp = value1;
            value1 = value2;
            return $"{value1},{value2}";

        }
    }

}