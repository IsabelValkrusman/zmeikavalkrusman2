﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public point()
        {
        }
        public point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;

        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}