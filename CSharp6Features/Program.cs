using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6Features
{
    class Program
    {
        static void Main(string[] args)
        {
            new ExceptionFilters().DoStuff();

            Console.Read();
        }

        public static char IndexedItem(string[] arr)
        {
            var c = arr?[0]?.First() ?? 'c';
            return c;
        }
    }    
}
