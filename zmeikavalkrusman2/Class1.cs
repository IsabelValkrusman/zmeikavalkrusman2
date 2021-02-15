using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    class Class1
    {
        List<point> pList;

        public Class1(int xLeft, int xReight, int y, sym)
        {
            pList = new List<point>();
            for(int x= xLeft; x<= xRight; x++)
            {
                point p = new point(xLeft, y, sym);
                pList.Add(p);
            }
            //point p1 = new point(4, 4, '*');
            //point p2 = new point(5, 4, '*');
            //point p3 = new point(6, 4, '*');
            //pList.Add(p1);
            //pList.Add(p2);
            //pList.Add(p3);
        }
        public void Drow()
        {
            foreach(point p in pList)
            {
                p.draw();
            }
       
        }
    }
}
