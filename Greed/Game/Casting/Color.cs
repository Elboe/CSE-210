using System.Collections.Generic;


namespace Greed.Game.Casting
{
    // holds information about the color
    public class Color
    {
        // properties
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;

        // constructor
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        // gets alpha
        public int GetAlpha()
        {
            return alpha;
        }

        // gets blue
        public int GetBlue()
        {
            return blue;
        }

        // gets green
        public int GetGreen()
        {
            return green;
        }

        // gets red
        public int GetRed()
        {
            return red;
        }

    }
}