using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panpoon.Sprites
{
    public class Ball : Sprite
    {
        private float _timer = 0f;
        private Vector2? _startPosition = null;
        private float? _startSpeed;
        private bool _isPlaying;

        public Score Score;
        public int SpeedincrementSpan = 10;

        public Ball(Texture2D texture)
            : base(texture)
        {
            Speed = 3f;
        }

        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            if (_startPosition == null)
            {
                _startPosition = Position;
                _startSpeed = Speed;

                var direction = Game1.Random.Next(0, 4);

                switch (direction)
                {
                    case 0;
                        Velocity = new Vector2(1, 1);
                        break;
                    case 1;
                        Velocity = new Vector2(1,-1);
                        break;
                    case 2;
                        Velocity = new Vector2(-1,-1);
                        break;
                    case 3;
                        Velocity = new Vector2(-1, 1);
                        break;
                }

                Position = (Vector2)_startPosition;
                Speed = (float)_startSpeed;
                _timer = 0;
                _isPlaying = false;
            }
        }
    }
}
