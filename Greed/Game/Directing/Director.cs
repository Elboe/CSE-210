using System;
using System.Collections.Generic;
using Greed.Game.Casting;
using Greed.Game.Services;


namespace Greed.Game.Directing
{
    // controls the flow of the game
    public class Director
    {
        // properties
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        public Score score = new Score();

        //constructor
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        // starts the game
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.DrawActor(cast.GetFirstActor("banner"));
            videoService.CloseWindow();
        }

        // gets keyboard input
        private void GetInputs(Cast cast)
        {
            Actor player = cast.GetFirstActor("player");
            Point velocity = keyboardService.GetDirection();
            player.SetVelocity(velocity);   
        }

        // detects collisions and updates player
        private void DoUpdates(Cast cast)
        {
            Random random = new Random();
            Actor banner = cast.GetFirstActor("banner");
            Actor player = cast.GetFirstActor("player");
            List<Actor> gems = cast.GetActors("gems");
            List<Actor> rocks = cast.GetActors("rocks");

            string currentScore = score.getScore().ToString();
            banner.SetText(currentScore);
            
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            player.MoveNext(maxX, maxY);

            foreach (Actor actor in gems)
            {
                // move
                Gem gem = (Gem) actor;
                gem.MoveNext(maxX, maxY);

                // checks for collision
                if (player.GetPosition().Equals(actor.GetPosition()))
                {
                    score.updateScore(gem.getScore());

                    // creates position
                    int ran = random.Next(1,maxX);
                    int rem = ran % 15;
                    int x = ran - rem;

                    Point new_pos = new Point(x, 0);
                    gem.SetPosition(new_pos);
                }

                // check for hitting bottom
                if (actor.GetPosition().GetY() >= maxY)
                {
                    // creates position
                    int ran = random.Next(1,maxX);
                    int rem = ran % 15;
                    int x = ran - rem;

                    Point new_pos = new Point(x, 0);
                    gem.SetPosition(new_pos);
                }
            }

            foreach (Actor actor in rocks)
            {
                // move
                 Rock rock = (Rock) actor;
                 rock.MoveNext(maxX, maxY);

                // checks for collisions
                if (player.GetPosition().Equals(actor.GetPosition()))
                {
                    score.updateScore(rock.getScore());

                    // creates position
                    int ran = random.Next(1,maxX);
                    int rem = ran % 15;
                    int x = ran - rem;

                    Point new_pos = new Point(x, 0);
                    rock.SetPosition(new_pos);
                }

                // checks for hit bottom
                if (actor.GetPosition().GetY() >= maxY)
                {
                    // creates position
                    int ran = random.Next(1,maxX);
                    int rem = ran % 15;
                    int x = ran - rem;

                    Point new_pos = new Point(x, 0);
                    rock.SetPosition(new_pos);
                }
            }
            
        }

        // draws actors
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }

    }
}