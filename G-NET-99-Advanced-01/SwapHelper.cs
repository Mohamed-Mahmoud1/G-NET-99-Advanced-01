using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_99_Advanced_01
{
    internal class SwapHelper
    {

        public static void Swap<T>(ref T number01,ref T number02)
        {
            T temp;
            temp = number01;
            number01 = number02;
            number02 = temp;
        }

    }
}
