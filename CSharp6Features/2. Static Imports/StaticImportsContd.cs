using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using static System.Threading.Tasks.Parallel;
using static System.Linq.Enumerable;

namespace CSharp6Features
{
    public class StaticImportsContd
    {
        public StaticImportsContd()
        {
            var list = Range(0, 999);
            ForEach(list, i => WriteLine(Abs(i)));
        }
    }
}
