using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiJuegoUno2022
{
    class Fireball : Sprite
    {
        public Fireball(ContentManager contentManager) : this(contentManager, new Point())
        {

        }

        public Fireball(ContentManager contentManager, Point location) : base("Fireball", location, new Point(50))
        {
            this.LoadContent(contentManager);
        }

        public void MoveUp()
        {
            this.Location = new Point(this.Location.X, this.Location.Y - 5);
        }

    }
}

