using System;
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
        public ConsoleColor color;
        public Point()
        {

        }
        public Point(int x_, int y_, char sym_, string color_)
        
        {
            x = x_;
            y = y_;
            sym = sym_;
            color = color;
        }
        public Point (Point p, ConsoleColor color)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            color = color;
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
            else if(direction==Direction.PAUS)
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
            Console.ForegroundColor = color;
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

}
}
