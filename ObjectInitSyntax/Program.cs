using System;
using ObjectInitSyntax.Entities;
using ObjectInitSyntax.Entities.Enums;

namespace ObjectInitSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle
            {
                TopLeft = new Point(-4, 2, Colors.Blue),
                TopRight = new Point(4, 2, Colors.Blue),
                BottomLeft = new Point(-4, -2, Colors.Blue),
                BottomRight = new Point(4, -2, Colors.Blue)
            };
        }
    }
}
