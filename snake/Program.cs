using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineLeft = new VerticalLine(0, 24, 0, '+');
            VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
            lineUp.Draw();
            lineDown.Draw();
            lineLeft.Draw();
            lineRight.Draw();
                       
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handler(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
