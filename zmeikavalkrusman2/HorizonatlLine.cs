using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    public class HorizonatlLine : Figure
    {
        public HorizontalLine(int xUp, int xDown, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xUp; x <= xDown; x++)
            {
                Point p = new Point(x, y, sym, ConsoleColor.White);
                pList.Add(p);
            }
        }
    }
}
