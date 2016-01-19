using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6Features
{
    public sealed class NameofOperator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;




        private string _myString;
        public string MyString
        {
            get { return _myString; }
            set
            {
                _myString = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MyString")); 
            }
        }
        



        public void ArgumentNull(string item)
        {
            if (item == null)
                throw new ArgumentNullException("item"); 
        }




        public void GetTypeName<T, TKey>(T item, TKey otherItem)
        {
            
        }

    }
}
