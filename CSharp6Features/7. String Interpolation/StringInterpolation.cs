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
            var fullname = string.Format("Hello {0} {1}", first, last);

            //new
             fullname = $"Hello {first} {last}";
        }
        
        public void Formatting()
        {
            decimal money = 36537.45125M;

            Console.WriteLine($"{money:C2}");
        }

        public void ConditionalExpression()
        {
            var first = "David";
            var last = "Rector";
            var gender = "M";

            string result = $"Hello, {(gender == "M" ? "Mr." : "Miss")} {first} {last}";
        }

        public void StringLiteral()
        {
            var directory = "C:";
            var file = "myFile.txt";

            string x = $@"{directory}\{file}";
        }
    }
}
