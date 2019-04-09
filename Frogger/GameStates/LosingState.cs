using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Frogger {
	class LosingState : GameState {
		public LosingState() {
			gameObjectList.Add(new GameObject("spr_gameover_screen"));
		}

		public override void Update(GameTime gameTime) {
			base.Update(gameTime);

			if(GameEnvironment.KeyboardState.GetPressedKeys().Count() > 0 &&
				GameEnvironment.previousState.GetPressedKeys().Count() == 0) {
				GameEnvironment.SwitchTo(0);
			}
		}
	}
}