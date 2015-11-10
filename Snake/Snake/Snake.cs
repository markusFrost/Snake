﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
         Direction direction;

        public Snake( Point tail, int length, Direction direction )
        {
            this.direction = direction;
            pList = new List<Point>(); 
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail); // Перерисовывать все не нужно. Нужно лишь удалить первый элемент

            Point head = GetNextPoint(); // решаем в какую стророну движется голова 
            pList.Add(head); // и добавить к голове новый

            tail.Clear();
            head.Draw();

            
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();

            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }



        public void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
               direction = Direction.DOWN;
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
        }
    }
}
