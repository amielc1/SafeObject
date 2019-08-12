using System;
using System.Collections.Generic;
using System.Text;

namespace SafeObject
{
    public class SafeObject<T>
    {

        private T _Value;

        public T Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }


    }
}
