using System;
using System.Collections.Generic;
using System.Text;

namespace SD1
{
    class HorizontalLine : Figure
    {
       

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            pointList = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point myPoint = new Point(i, y, symbol);
                pointList.Add(myPoint);

            }


        }
        public void DrawHorizontalLine()
        {
            foreach(Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}
