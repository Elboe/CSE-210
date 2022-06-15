using System;


namespace Greed.Game.Casting
{
    // things that participate in the game
    public class Actor
    {
        // properties
        private string text = "";
        private int fontSize = 15;
        private Color color = new Color(255, 255, 255);
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);

        //constructor
        public Actor()
        {
            
        }

        //methods 
        public Color GetColor()
        {
            return color;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public Point GetPosition()
        {
            return position;
        }

        public string GetText()
        {
            return text;
        }

        public Point GetVelocity()
        {
            return velocity;
        }

        // moves the actor according to the velocity
        public void MoveNext(int maxX, int maxY)
        {
            int x = (position.GetX() + velocity.GetX());
            int y = (position.GetY() + velocity.GetY());
            position = new Point(x, y);
        }

        // sets the actor's color
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this.color = color;
        }

        // sets the actor's size
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this.fontSize = fontSize;
        }

        // sets the actors position
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        // sets the actor text
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }

        // sets the actor's velocity
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }

    }
}