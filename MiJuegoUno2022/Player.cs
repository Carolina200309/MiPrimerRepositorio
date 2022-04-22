using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiJuegoUno2022
{
    class Player : Sprite
    {
        public List<Fireball> fireballs;
        public Player() : base("Spaceship", new Point(300, 450), new Point(200, 200))
        {
            fireballs = new List<Fireball>();
        }

        public void Shoot(ContentManager content, Point location)
        {
            fireballs.Add(new Fireball(content, location));

        }

        /// <summary>
        /// Move the object horizontally
        /// </summary>
        /// <param name="direction">Boolean, True will move the object to the right, False will move the object to the Left</param>
        public void Move(bool direction)
        {
            if (direction)
            {
                this.Location = new Point(this.Location.X + 5, this.Location.Y);
            }
            else
            {
                this.Location = new Point(this.Location.X - 5, this.Location.Y);
            }
        }
    }
}