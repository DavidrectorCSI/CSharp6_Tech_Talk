using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6Features
{
    public class ExceptionFilters
    {

        public void DoStuff()
        {
            int tries = 0;
            foreach(var i in Enumerable.Range(0,10))
            {
                ++tries;

                try
                {
                    throw new Exception();
                }
                catch(Exception e) 
                {
                    Console.WriteLine("Error Occurred");
                }
            }                
        }
    }
}
