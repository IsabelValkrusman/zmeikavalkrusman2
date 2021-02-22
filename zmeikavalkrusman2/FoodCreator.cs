﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    class FoodCreator
    {
        int mapW;
        int mapH;
        char sym;
        Random rand = new Random();
        public FoodCreator(int mapW, int mapH, char sym, ConsoleColor color_)
        {
            this.mapW = mapW;
            this.mapH = mapH;
            this.sym = sym;
            color = color_;
        }
        public point CreateFood()
        {
            int x = rand.Next(2, mapH - 2);
            int y = rand.Next(2, mapH - 2);
            return new point(x, y, sym, ConsoleColor.Green);
        }
    }
 }