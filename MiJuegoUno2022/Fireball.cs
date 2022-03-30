using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiJuegoUno2022
 {
    class Fireball
    {
        Texture2D sourceImage;
        Rectangle rectangle;
        string nameOfImage;


        public Fireball()
        {
            nameOfImage = "Fireball";
            rectangle = new Rectangle(0, 0, 50, 50);
        }

        public void LoadContent(ContentManager content)
        {
            sourceImage = content.Load<Texture2D>(nameOfImage);
        }

        public void MoveUp()
        {
            rectangle.Y -= 5;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sourceImage, rectangle, Color.White);
        }
    }
 }

