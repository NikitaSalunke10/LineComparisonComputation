using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    internal class CalculateLength
    {
        public double Length(int x1, int x2, int y1, int y2)
        {
            double line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));  // calculated the length for line1 i.e for points x1, x2 and y1, y2 
            return line;
        }
    }
}
