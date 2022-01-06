using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Figure
    {
        protected List<point> pointlist;

        public void Draw()
        {
            foreach (point point in pointlist)
            {
                point.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach(var point in pointlist)
            {
                if (figure.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsHit(point point)
        {
            foreach(var p in pointlist)
            {
                if (p.IsHit(point))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
