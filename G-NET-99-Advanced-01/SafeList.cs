using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_99_Advanced_01
{
    internal class SafeList<T>
    {
        private T[] items;

       
        public SafeList(int size)
        {
            items = new T[size];
        }

        public T ValueOfIndex(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                return default;
            }
            return items[index];
        }
    }
}
