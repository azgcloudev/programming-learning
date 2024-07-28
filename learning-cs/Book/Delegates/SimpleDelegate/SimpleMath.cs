using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    internal class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;

        /// <summary>
        /// Return the square of a given number.
        /// </summary>
        /// <param name="a">Integer to get the square.</param>
        /// <returns>Returns an integer</returns>
        public static int SquareNumber(int a) => a * a;
    }
}
