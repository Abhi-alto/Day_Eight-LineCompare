using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_comparasion
{
    internal class Line
    {
        public static double length(double x1, double y1, double x2, double y2)
        {
            return (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
        }
    }
}
