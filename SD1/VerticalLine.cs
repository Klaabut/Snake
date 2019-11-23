using System;
using System.Collections.Generic;
using System.Text;

namespace SD1
{
    class VerticalLine : Figure
    {
        

        public VerticalLine(int x, int yAbove, int yBelow, char symbol)
        {

            for (int i = yBelow; i <= yAbove; i++)
            {
                Point myPoint = new Point(x, i, symbol);
                pointList.Add(myPoint);

            }


        }
        public void DrawVerticalLine()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }
    }
}
