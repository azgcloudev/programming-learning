using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyPointAfterCreation
{
    internal class PointReadOnlyAfterCreation
    {
        public int Y { get; init; }
        public int X { get; init; }

        public PointReadOnlyAfterCreation(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }

        public PointReadOnlyAfterCreation() { }

        public void DisplayStats()
        {
            Console.WriteLine("Init only setters: [{0}, {1}]", X, Y);
        }
    }
}
