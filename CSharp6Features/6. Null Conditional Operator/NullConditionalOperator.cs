using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp6Features
{
    public class NullConditionalOperator
    {
        public event EventHandler MyEvent;

        
        public void DoEvent()
        {
            //old
            if (MyEvent != null)
            {
                MyEvent(this, null);
            }

            //new
        }

        public void ReadXml(XDocument doc)
        {
            //old
            string attributeValueOld;

            var testElement = doc.Descendants("MyElement").FirstOrDefault();
            if (testElement != null)
            {
                var attr = testElement.Attribute("MyAttribute");
                if (attr != null)
                {
                    attributeValueOld = attr.Value;
                }
            }

            //new

        }

        public void NullCoalescingAndValueTypes(List<string> list)
        {

        }

        //potential gotcha
        public static char IndexedItem(string[] arr)
        {
            var c = arr?[0]?.First() ?? 'c';
            return c;
        }
    }
}
