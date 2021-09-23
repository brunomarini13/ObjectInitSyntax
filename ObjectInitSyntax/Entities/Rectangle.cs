using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitSyntax.Entities
{
    class Rectangle
    {
        private Point topLeft, topRight, bottomLeft, bottomRight;

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }

        public Point TopRight
        {
            get { return topRight; }
            set { topRight = value; }
        }

        public Point BottomLeft
        {
            get { return bottomLeft; }
            set { bottomLeft = value; }
        }

        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

    }
}
