namespace Greed.Game.Casting
{
    // distance from relative origin
    public class Point
    {
        // properties
        private int x = 0;
        private int y = 0;

        // constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // adds given point with x and y
        public Point Add(Point other)
        {
            int x = this.x + other.GetX();
            int y = this.y + other.GetY();
            return new Point(x, y);
        }

        // checks if point is equal to other point
        public bool Equals(Point other)
        {
            return this.x == other.GetX() && this.y == other.GetY();
        }

        // gets x
        public int GetX()
        {
            return x;
        }

        //gets y
        public int GetY()
        {
            return y;
        }

        // scales point by multiplier
        public Point Scale(int factor)
        {
            int x = this.x * factor;
            int y = this.y * factor;
            return new Point(x, y);
        }
    }
}