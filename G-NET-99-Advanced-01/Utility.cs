using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_99_Advanced_01
{
    internal class Utility
    {
        public static T FindMax<T>(T[] items) where T : IComparable
        {
            T Max = items[0];
            foreach (var item in items)
            {
                if (item.CompareTo(Max) > 0)
                    Max = item;
            }
            return Max;
        }

    }
}
