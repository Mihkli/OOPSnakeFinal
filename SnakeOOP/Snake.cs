using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeOOP
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(point tail, int length, Direction _direction)
        {
            direction = _direction;
            pointlist = new List<point>();
            for(int i = 0; i < length; i++)
            {
                point p = new point(tail);
                p.Move(i, direction);
                pointlist.Add(p);
            }
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void Move()
        {
            point tail = pointlist.First();
            pointlist.Remove(tail);
            tail.Clear();

            point head = getnextpoint();
            pointlist.Add(head);
            head.Draw();
        }

        public point getnextpoint()
        {
            point head = pointlist.Last();
            point nextpoint = new point(head);
            nextpoint.Move(1, direction);
            return nextpoint;
             
        }

        public void Handlekeys(ConsoleKey key)
        {
            if(key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            } else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            } else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            } else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }

        }

        public bool Eat(point food)
        {
            point head = getnextpoint();
            if (head.IsHit(food))
            {
                food.symb = head.symb;
                pointlist.Add(food);
                return true;
            } else
            {
                return false;
            }
        }

        public bool ishittail()
        {
            point head = pointlist.Last();
            for(int i = 0; i < pointlist.Count - 2; i++)
            {
                if (head.IsHit(pointlist[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
