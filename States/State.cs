﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace UlearnGame.States
{
    public abstract class State // общий класс для всех окон в игре
    {
        protected Game1 _game;

        protected ContentManager _content;

        public State(Game1 game, ContentManager content)
        {
            _game = game;

            _content = content;
        }

        public abstract void LoadContent();

        public abstract void Update(GameTime gameTime);

        public abstract void PostUpdate(GameTime gameTime);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}