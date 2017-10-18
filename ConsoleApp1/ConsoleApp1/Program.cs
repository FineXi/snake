using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.sym = '#';
            for (int x1 = 1; x1 <= 20; x1++)
            {
                for (int y1 = 1; y1 <= 20; y1++)
                {
                    if (x1 == y1)
                    {
                        p1.x = x1;
                        p1.y = y1;
                        p1.Draw();
                    }
                }
            }

            Console.ReadLine();
            
        }

    }
}
