using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_99_Advanced_01
{
    internal class Person<T> where T :class
    {
        public T Value { get; set; }
    }
}
