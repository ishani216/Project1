using System;

namespace context
{
    internal class Trips
    {
        internal class OrderBy
        {
            private Func<object, object> p;

            public OrderBy(Func<object, object> p)
            {
                this.p = p;
            }
        }
    }
}