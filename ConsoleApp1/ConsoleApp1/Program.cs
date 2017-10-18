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
            char sym1 = '*';
            for (int x1 = 1; x1 <= 20; x1++)
            {
                for (int y1 = 1; y1 <= 20; y1++)
                {
                    if (x1 == y1)
                    {
                        Draw(x1, y1, sym1);
                    }
                }
            }

            Console.ReadLine();
            
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
