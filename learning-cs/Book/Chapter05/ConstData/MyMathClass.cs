using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    public class MyMathClass
    {
        public const double PI = 3.14;
        public readonly double PIDecimals;
        public static readonly double PI20 = 3.1415;

        public MyMathClass()
        {
            PIDecimals = 3.1415116;
        }
    }
}
