using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Greed.Game.Casting;
using Greed.Game.Directing;
using Greed.Game.Services;


namespace Unit04
{
    // runs the game
    class Program
    {
        private static int frameRate = 12;
        private static int maxX = 900;
        private static int maxY = 600;
        private static int cellSize = 15;
        private static int fontSize = 15;
        private static int columns = 60;
        private static int rows = 40;
        private static string caption = "Greed";
        private static Color white = new Color(255, 255, 255);
        private static Point velocity = new Point(0, 15);
        private static int MAX_ROCKS = 70;
        private static int MAX_GEMS = 30;


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            // create the banner(Displays the points)
            Actor banner = new Actor();
            banner.SetText("");
            banner.SetFontSize(fontSize);
            banner.SetColor(white);
            banner.SetPosition(new Point(cellSize, 0));
            cast.AddActor("banner", banner);

            // create the player
            Actor player = new Actor();
            player.SetText("#");
            player.SetFontSize(fontSize);
            player.SetColor(white);
            player.SetPosition(new Point(maxX / 2, maxY - 15));
            cast.AddActor("player", player);

            // create the gems and rocks.
            Random random = new Random();
            for (int i = 0; i < MAX_GEMS; i++)
            {
                string text = ((char)random.Next(33, 126)).ToString();

                int x = random.Next(1, columns);
                int y = random.Next(-maxY,-1);
                Point position = new Point(x, y);
                position = position.Scale(cellSize);

                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);

                Gem gem = new Gem();
                gem.SetText(Convert.ToChar(42).ToString());
                gem.SetFontSize(fontSize);
                gem.SetColor(color);
                gem.SetPosition(position);
                gem.SetVelocity(velocity);
                cast.AddActor("gems", gem);
            }

            for (int i = 0; i < MAX_ROCKS; i++)
            {
                string text = ((char)random.Next(33, 126)).ToString();

                int x = random.Next(1, columns);
                int y = random.Next(-maxY,-1);
                Point position = new Point(x, y);
                position = position.Scale(cellSize);

                
                Color color = new Color(255, 153, 0);

                Rock rock = new Rock();
                rock.SetText(Convert.ToChar(48).ToString());
                rock.SetFontSize(fontSize);
                rock.SetColor(color);
                rock.SetPosition(position);
                rock.SetVelocity(velocity);
                cast.AddActor("rocks", rock);
            }

            // start the game
            KeyboardService keyboardService = new KeyboardService(cellSize);
            VideoService videoService 
                = new VideoService(caption, maxX, maxY, cellSize, frameRate, false);
            Director director = new Director(keyboardService, videoService);
            director.StartGame(cast);
        }
    }
}