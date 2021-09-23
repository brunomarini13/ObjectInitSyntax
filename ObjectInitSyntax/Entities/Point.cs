using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectInitSyntax.Entities.Enums;

namespace ObjectInitSyntax.Entities
{
    class Point
    {
        public Colors Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y, Colors c)
        {
            X = x;
            Y = y;
            Color = c;
        }

        public static void Print(Point p)
        {
            Console.WriteLine("({0}, {1})", p.X, p.Y);
            Console.WriteLine("Point color is: {0}", p.Color);
        }
    }
}
