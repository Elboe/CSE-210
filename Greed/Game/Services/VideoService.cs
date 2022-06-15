using System.Collections.Generic;
using Raylib_cs;
using Greed.Game.Casting;


namespace Greed.Game.Services
{
    // displays game
    public class VideoService
    {
        // properties
        private int cellSize = 15;
        private string caption = "";
        private int width = 640;
        private int height = 480;
        private int frameRate = 0;
        private bool debug = false;

        // constructor
        public VideoService(string caption, int width, int height, int cellSize, int frameRate, 
                bool debug)
        {
            this.caption = caption;
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            this.frameRate = frameRate;
            this.debug = debug;
        }

        // closes window
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        // clears buffer
        public void ClearBuffer()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if (debug)
            {
                DrawGrid();
            }
        }

        // draws actor text
        public void DrawActor(Actor actor)
        {
            string text = actor.GetText();
            int x = actor.GetPosition().GetX();
            int y = actor.GetPosition().GetY();
            int fontSize = actor.GetFontSize();
            Casting.Color c = actor.GetColor();
            Raylib_cs.Color color = ToRaylibColor(c);
            Raylib.DrawText(text, x, y, fontSize, color);
        }

        // draws list of actors on  screen
        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }
        
        //copies buffer to screen
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }

       // gets grid size
        public int GetCellSize()
        {
            return cellSize;
        }

       // gets creen height
        public int GetHeight()
        {
            return height;
        }

        // gets screen width
        public int GetWidth()
        {
            return width;
        }

        // checks if window is open
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }

        // opens window
        public void OpenWindow()
        {
            Raylib.InitWindow(width, height, caption);
            Raylib.SetTargetFPS(frameRate);
        }

        // draws grid debug only
        private void DrawGrid()
        {
            for (int x = 0; x < width; x += cellSize)
            {
                Raylib.DrawLine(x, 0, x, height, Raylib_cs.Color.GRAY);
            }
            for (int y = 0; y < height; y += cellSize)
            {
                Raylib.DrawLine(0, y, width, y, Raylib_cs.Color.GRAY);
            }
        }

       // converts color to raylib color
        private Raylib_cs.Color ToRaylibColor(Casting.Color color)
        {
            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }

    }
}