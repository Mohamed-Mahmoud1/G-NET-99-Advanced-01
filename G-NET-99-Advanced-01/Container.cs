using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_99_Advanced_01
{
    internal class Container<T>
    {
        public Container(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
}
