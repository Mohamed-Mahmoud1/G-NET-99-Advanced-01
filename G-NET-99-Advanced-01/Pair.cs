using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_99_Advanced_01
{
    internal class Pair<Tkey,TValue>
    {
        public Pair(Tkey key, TValue value)
        {
            this.key = key;
            Value = value;
        }

        public Tkey key { get; set; }
        public TValue Value { get; set; }
    }
}
