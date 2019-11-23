using System;

namespace SnakeDraft
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        
        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.SetWindowSize(25, 25);
            Console.SetBufferSize(25, 25);*/
            /*Console.Clear();
            int x1 = 10;
            int y1 = 10;
            char symbol = '*';

           /* Console.SetCursorPosition(x1, y1);
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;

            int x2 = 50;
            int y2 = 55;
            char symbol1 = '#';
           /* Console.SetCursorPosition(x2, y2);
            Console.Write(symbol1);*/

           // Draw(x2, y2, symbol1);*/


            Point punkt = new Point(30, 40, '*');
            // Draw(punkt.x, punkt.y, punkt.symbol);
            punkt.Draw();


            Point punkt1 = new Point(31, 41, '?');
            punkt1.Draw();
          





            Console.ReadLine();
        }

        public static void Draw(int x, int y, char symbol)
        {
            
        }

    }
}
