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
            Console.SetBufferSize(80, 25);
            HLine border_top = new HLine(0, 78, 0, '*');
            border_top.Draw();
            HLine border_bottom = new HLine(0, 78, 24, '*');
            border_bottom.Draw();
            VLine border_left = new VLine(0, 0, 24, '*');
            border_left.Draw();
            VLine border_right = new VLine(78, 0, 24, '*');
            border_right.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            for (int tm = 0; tm < 500; tm++)
            {
                snake.Move();
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
            
        }

    }
}
