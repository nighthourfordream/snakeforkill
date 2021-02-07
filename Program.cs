using System;
using System.Collections.Generic;

namespace Snakeit
{
    class Program
    {
        static void Main(string[] args)
        {
            


          


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow(); 
        
    
        }

    }
}
