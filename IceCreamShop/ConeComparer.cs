using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            double diff = x.Cost - y.Cost;
            if (diff == 0)
            {
                return 0;
            }
            else if (diff < 0)
            {
                return -1;
            }
            else 
            {
                return 1;
            }
        }
    }
}
