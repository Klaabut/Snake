using System;
using System.Threading;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;

namespace SD1
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;
        public string  file = "MGSBM.mp3";


        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public Point(Point _p)
        {
            x = _p.x;
            y = _p.y;
            symbol = _p.symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public  void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if ( direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
            
        }
        public bool IsHit(Point point)
        {
            return point.x == this.x && point.y == y;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            


            int score = 0;
            int speed = 200;
           
            int speedLevel = 0;

            

            Console.SetWindowSize(100, 25);
            Console.SetBufferSize(100, 25);

            Walls walls = new Walls(80, 25);
            walls.DrawWalls();

            /* HorizontalLine topLine = new HorizontalLine(0, 78, 0, '*');
             topLine.DrawFigure();
             HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '*');
             bottomLine.DrawFigure();
             VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
             leftLine.DrawFigure();
             VerticalLine rightLine = new VerticalLine(78, 24, 0, '*');
             rightLine.DrawFigure();*/


            Point tail = new Point(6, 5, '*');
            Snake snake = new Snake(tail, 4, Direction.RIGHT);
            snake.DrawFigure();

            FoodCatering foodCatered = new FoodCatering(80, 25, '$');
            Point food = foodCatered.CaterFood();
            food.Draw();

            while (true)
            {
                
                if (walls.IsHitByFigure(snake))
                {
                    Console.Clear();
                    
                    WriteGameOver();
                    if (score > 1 || score == 0)
                    {
                        Console.WriteLine($" You got {score} points!");
                    }
                    else
                    {
                        Console.WriteLine($"You got {score} point!");
                    }
                    Sounds.DeathSound();
                    break;
                    
                }
                WriteOngoinScore(score, speedLevel);
                if (snake.Eat(food))
                {
                    food = foodCatered.CaterFood();
                   Sounds.GainSound();
                    score=+ 5;
                    
                    food.Draw();
                    speed -= 10;
                    speedLevel++;
                    
                }
                else
                {
                    snake.MoveSnake();
                }
                
                if (Console.KeyAvailable)
                {
                    
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ReadUserKey(key.Key);
                }
               


                
                Thread.Sleep(speed);
                
            }
            

           



        }
            public static void WriteGameOver()
            {
            int xOffset = 35;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            ShowMessage("________________", xOffset, yOffset++);
            ShowMessage("GAME OVER", xOffset, yOffset++);
            ShowMessage("________________", xOffset, yOffset++);

        }
        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        
        public static void WriteOngoinScore(int score, int speedLevel)
        {
            int xOffset = 81;
            int yOffset = 10;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            ShowMessage("________________", xOffset, yOffset++);
            ShowMessage($"Current score: {score}", xOffset, yOffset++);
            ShowMessage($"Current speed: {speedLevel}", xOffset, yOffset++);
            ShowMessage("________________", xOffset, yOffset++);
        }
        

    }
}
