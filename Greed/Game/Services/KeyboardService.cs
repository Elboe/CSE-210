using Raylib_cs;
using Greed.Game.Casting;


namespace Greed.Game.Services
{
    // detects keyboard input
    public class KeyboardService
    {
        // properties
        private int cellSize = 15;

        //constructor
        public KeyboardService(int cellSize)
        {
            this.cellSize = cellSize;
        }

        // converts keypress into direction
        public Point GetDirection()
        {
            int dx = 0;
            int dy = 0;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                dx = -1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                dx = 1;
            }

            Point direction = new Point(dx, dy);
            direction = direction.Scale(cellSize);

            return direction;
        }
    }
}