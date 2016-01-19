using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CSharp6Features
{
    public sealed class Other
    {
        public void IndexInitializer()
        {
            //old
            new Dictionary<int, string>
            {
                {1, "hello"},
                {2, "howdy"}
            };
            

            //new
            
        }

        public async void AwaitInCatchFinally()
        {
            try
            {

            }
            catch(Exception e)
            {
                
            }
            finally
            {
 
            }
        }

        
    }
}
