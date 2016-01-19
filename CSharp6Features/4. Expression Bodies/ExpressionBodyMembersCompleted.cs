using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6Features
{
    public class ExpressionBodyMembersCompleted
    {
        public DateTime Yesterday { get { return DateTime.Now.AddDays(-1); } }

        public void PrintName(string first, string last)
        {
            Console.WriteLine($"{first} {last}");
        }


    }

    public class ExpressionBodyMembersNewCompleted
    {
        public DateTime Yesterday => DateTime.Now.AddDays(-1);

        public void PrintName (string first, string last) => Console.WriteLine($"{first} {last}");
    }
    
}
