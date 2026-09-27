using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_99_Advanced_01
{
    internal interface IRepository<T>
    {
        public T GetAll();
    }
}
