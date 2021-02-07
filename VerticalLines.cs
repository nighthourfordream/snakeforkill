using System;
using System.Collections.Generic;
using System.Text;

namespace Snakeit
{
    class VerticalLines : Figure
    {
       

        public VerticalLines( int yUp, int yDown, int x, char sym )
        {
            pList = new List<Point>();
            for(int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

    }
}
