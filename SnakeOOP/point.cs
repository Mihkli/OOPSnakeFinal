using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class point
    {
        public int x;
        public int y;
        public char symb;

        public point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public point(point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }
        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
        public void Clear()
        {
            symb = ' ';
            Draw();
        }
        public bool IsHit(point p)
        {
            return p.x == x && p.y == y;
        }
    }
}
