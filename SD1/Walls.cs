using System;
using System.Collections.Generic;
using System.Text;

namespace SD1
{
    class Walls
    {
        Random rnd = new Random();
        List<Figure> wallList;
       



        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine topLine = new HorizontalLine(0, mapWidth-2, 0, '#');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight-1, '#');
            VerticalLine leftLine = new VerticalLine(0, mapHeight-1, 0, '#');
            VerticalLine rightLine = new VerticalLine(mapWidth-1, mapHeight-1, 0, '#');
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

        }
        
        public void DrawWalls()
        {
            foreach(Figure wall in wallList)
            {
                wall.DrawFigure();
            }
        }
        public bool IsHitByFigure(Figure figure)
        {
            foreach(Figure wall in wallList)
            {
                if(wall.IsHitByFigure(figure))
                {
                    return true;
                }
            }
            return false;
        }
        /*public Point DrawRandomObst()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            
            return new Point(x, y, symbol);
        }*/
    }
}
