using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Walls
    {
        List<Figure> walllist;

        public Walls(int mapWidth, int mapHeight)
        {
            walllist = new List<Figure>();
            HorizontalLine top = new HorizontalLine(0, 80, 0, '#');
            VerticalLine left = new VerticalLine(0, 25, 0, '#');
            HorizontalLine bot = new HorizontalLine(0, 80, 25, '#');
            VerticalLine right = new VerticalLine(0, 25, 80, '#');
            walllist.Add(top);
            walllist.Add(bot);
            walllist.Add(left);
            walllist.Add(right);
            HorizontalLine block = new HorizontalLine(5, 12, 7, '#');
            walllist.Add(block);
            VerticalLine block2 = new VerticalLine(6, 10, 70, '#');
            walllist.Add(block2);
        }

        public void Draw()
        {
            foreach(var wall in walllist)
            {
                wall.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach(var wall in walllist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
