using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class HorizontalLine : Figure
    {

        public HorizontalLine(int xleft, int xright, int y, char symb)
        {
            pointlist = new List<point>();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = xleft; i <= xright; i++)
            {
                point p = new point(i, y, symb);
                pointlist.Add(p);
            }
        }
       
    }
}
