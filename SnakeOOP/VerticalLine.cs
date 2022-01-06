using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class VerticalLine : Figure
    {
        
        public VerticalLine(int yup, int ydown, int x, char symb)
        {
            pointlist = new List<point>();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = yup; i <= ydown; i++)
            {
                point p = new point(x, i, symb);
                pointlist.Add(p);
                
            }

        }
       
    }
}
