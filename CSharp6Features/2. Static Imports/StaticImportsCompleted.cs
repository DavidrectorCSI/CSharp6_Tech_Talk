using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace CSharp6Features
{
    public class StaticImportsCompleted
    {
        public void DoStuff()
        {
            //old
            var ten = Math.Sqrt(100);

            //new
            var nine = Sqrt(81);
        }
    }
}
