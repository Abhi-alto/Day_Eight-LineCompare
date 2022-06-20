using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_comparasion
{
    internal class Line
    {
        public static double length(int num)
        {
            Console.WriteLine("Enter cordinates for line "+num);
            Console.WriteLine("Enter x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            return (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
        }

    }
}
