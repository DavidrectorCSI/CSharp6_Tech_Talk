using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6Features
{
    public class AutoPropertiesCompleted
    {
        //property with default value
        public int Number { get; set; }

        //readonly property
        private readonly string _readOnly;
        public string ReadOnly { get { return _readOnly; } }

        public AutoPropertiesCompleted()
        {
            _readOnly = "Read Only";
            Number = 15;
        }
    }

    public class AutoPropertiesNewCompleted
    {
        //property with default value
        public int Number { get; set; } = 15;

        //readonly property
        public string ReadOnly { get; }

        public AutoPropertiesNewCompleted()
        {
            ReadOnly = "readonly";
        }
    }
}
