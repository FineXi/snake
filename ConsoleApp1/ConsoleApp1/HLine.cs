using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HLine : Figure
    {
        public HLine(int x_Left, int x_Right, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = x_Left; x <= x_Right; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
       
    }
}
