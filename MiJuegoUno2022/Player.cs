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
        private List<Fireball> fireballs;
        public Player() : base("Spaceship", new Point(300, 450), new Point(200, 200))
        {
            fireballs = new List<Fireball>();
        }

        public void Shoot()
        {
            fireballs.Add(new Fireball());
        }

        /// <summary>
        /// Move the object horizontally
        /// </summary>
        /// <param name="direction">Boolean, True will move the object to the right, False will move the object to the Left</param>
        public void Move(bool direction)
        {
            if (direction)
            {
                this.rectangle.X += 5;
            }
            else
            {
                this.rectangle.X -= 5;
            }
        }

    }
}
