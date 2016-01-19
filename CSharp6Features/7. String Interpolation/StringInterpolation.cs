using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6Features
{
    public sealed class StringInterpolation
    {

        public void DoStuff()
        {
            //old
            var first = "David";
            var last = "Rector";
            Console.WriteLine("Hello {0} {1}", first, last);

            //new

        }
        
        public void Formatting()
        {
            decimal money = 36537.45125M;
            
        }

        public void ConditionalExpression()
        {
            var first = "David";
            var last = "Rector";
            var gender = "M";


        }

        public void StringLiteral()
        {
            var directory = "C:";
            var file = "myFile.txt";

        }
    }
}
