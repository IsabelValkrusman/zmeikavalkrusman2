﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point()
        {

        }
        public Point(int x_, int y_, char sym_)
        
        {
            x = x_;
            y = y_;
            sym = sym_;

        }
        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;

        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
            else if(direction==Direction.PAUSE)
            {
                Console.ReadKey();
            }

        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }

        internal bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

    }

}



