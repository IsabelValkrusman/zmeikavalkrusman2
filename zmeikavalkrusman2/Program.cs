using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x=" + x);

            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2. x=" + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x=" + x);

            point p1 = new point(1, 3, '*');
            Move(p1, 10, 10 =);
            Console.WriteLine("Call Move. p1.x=" + p1.x + ",p1.y" + p1.y);
            //p1.x = 1;
            //p1.y = 3;
            //p1.sym = '*';
            p1.draw();

            point p2 = new point(4, 5, '#');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1=p2. p1.x=" + p1.x+",p1.y="+p1.y+"; p2.x="+p2.x+", p2.y="+p2.y);

            p1 = new point(1, 3, '#');
            update(p1);
            Console.WriteLine("Call Move. p1.x=" + p1.x + ",p1.y=" + p1.y);



            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            //Draw(x1, y1, sym1);

            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';

            //Draw(x2, y2, sym2);

            Console.ReadLine();

        }
          //static void Draw(int x, int y, char sym)
        //{
        //    //Console.SetCursorPosition(x, y);
        //    //Console.Write(sym);



        //}
    }
}
