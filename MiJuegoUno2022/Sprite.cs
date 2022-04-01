using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiJuegoUno2022
{
    class Sprite
    {
        private string sourceImageName;

        private Texture2D texture2D;

        private Rectangle rectangle;

        private Point location;

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        private Point size;

        public Point Size
        {
            get { return size; }
            set { size = value; }
        }

        public string SourceImageName { get { return this.sourceImageName; } }


        /// <summary>
        /// OJO: If you call this overload constructor you wont be able to change it later
        /// In fact, you will have a default image displaying 'No Image'
        /// </summary>
        public Sprite() : this("NoImage")
        {

        }

        public Sprite(string sourceImageName)
            : this(sourceImageName, new Point(0, 0), new Point(20, 20))
        {

        }

        public Sprite(string sourceImageName, Point location, Point size)
        {
            this.sourceImageName = sourceImageName;
            this.location = location;
            this.size = size;
            this.rectangle = new Rectangle(this.location, this.size);
        }

        /// <summary>
        /// This method must be called to load an external asset to the RAM Memory
        /// </summary>
        /// <param name="contentManager">Send the principal content manager of the Game</param>
        public void LoadContent(ContentManager contentManager)
        {
            this.texture2D = contentManager.Load<Texture2D>(this.sourceImageName);
        }

        /// <summary>
        /// This method should be called to draw the sprite on the screen
        /// </summary>
        /// <param name="spriteBatch">Send the principal Spritebatch of the Game</param>
        /// <param name="color">Specify in which background color the image will be drawn</param>
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(this.texture2D, this.rectangle, color);
        }
    }
}

