using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Frogger {
    class Frog : GameObject {
        public Frog() : base("spr_frog") {
			lives = 3;
        }

        public override void Init() {
            base.Init();
			speed = 40;
            position.X = GameEnvironment.Screen.X/2 - this.texture.Width / 2;
            position.Y = GameEnvironment.Screen.Y - this.texture.Height-10;
			velocity.X = velocity.Y = 0;
        }

		public override void Update() {
			base.Update();

			if(GameEnvironment.KeyboardState.IsKeyDown(Keys.Left) ||
				GameEnvironment.KeyboardState.IsKeyDown(Keys.Right) ||
				GameEnvironment.KeyboardState.IsKeyDown(Keys.Up) ||
				GameEnvironment.KeyboardState.IsKeyDown(Keys.Down)) {
				thisFrameKeyDown = true;
			} else {
				thisFrameKeyDown = false;
			}

			if(GameEnvironment.KeyboardState.IsKeyDown(Keys.Left) && !lastFrameKeyDown) {
				velocity.X -= speed;
			} else if(GameEnvironment.KeyboardState.IsKeyDown(Keys.Right) && !lastFrameKeyDown) {
				velocity.X += speed;
			} else if(GameEnvironment.KeyboardState.IsKeyDown(Keys.Up) && !lastFrameKeyDown) {
				velocity.Y -= speed;
			} else if(GameEnvironment.KeyboardState.IsKeyDown(Keys.Down) && !lastFrameKeyDown) {
				velocity.Y += speed;
			}

			position += velocity;
			velocity.X = velocity.Y = 0;

			// "clamp" the position to make sure it never goes out of screen bounds           
			position.X = MathHelper.Clamp(position.X, 0, GameEnvironment.Screen.X - texture.Width);
			position.Y = MathHelper.Clamp(position.Y, 30, GameEnvironment.Screen.Y - texture.Height-10);

			if(lives < 1) {
				Init();
				this.lives = 3;
				GameEnvironment.SwitchTo(3);
			}
		}
	}
}
