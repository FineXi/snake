using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VLine : Figure
    {
       
        public VLine(int x, int y_Top, int y_Bottom, char sym)
        {
            pList = new List<Point>();
            for (int y = y_Top; y <= y_Bottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        
    }
}
