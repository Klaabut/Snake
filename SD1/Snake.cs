using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SD1
{
    enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    class Snake: Figure
    {
        public Direction Direction;

        public Snake(Point tail, int length,Direction _direction)
        {
            Direction = _direction;
            for(int i = 0; i < length; i++)
            {
                Point newPoint = new Point(tail);
                newPoint.Move(i, Direction);
                pointList.Add(tail);
            }
        }


        public void MoveSnake()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);
            tail.Clear();
            head.Draw();
        }


        public Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        public void ReadUserKey(ConsoleKey key)
        {
            if(key == ConsoleKey.LeftArrow)
            {
                Direction = Direction.LEFT;

            }
            else if ( key == ConsoleKey.RightArrow)
            {
                Direction = Direction.RIGHT;

            }
            else if ( key == ConsoleKey.UpArrow)
            {
                Direction = Direction.UP;
            }
            else if ( key == ConsoleKey.DownArrow)
            {
                Direction = Direction.DOWN;
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {

                food.symbol = head.symbol;
                pointList.Add(food);
                
                return true;
                
            }
            else
            {
                return false;
            }


        }
        
        
    }
}
