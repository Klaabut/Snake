using System;
using System.Collections.Generic;
using System.Text;

namespace SD1
{
    class FoodCatering
    {
        int mapWidth;
            int mapHeight;
        char Symbol;

        Random rnd = new Random();

        public FoodCatering(int _mapWidth, int _mapHeight, char _symbol)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            Symbol = _symbol;
        }

        public Point CaterFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, Symbol);
        }

    }
}
