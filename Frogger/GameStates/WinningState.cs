using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Frogger {
	class WinningState : GameState {
		public WinningState() {
			gameObjectList.Add(new GameObject("spr_win_screen"));
		}

		public override void Update(GameTime gameTime) {
			base.Update(gameTime);

			if(GameEnvironment.KeyboardState.GetPressedKeys().Count() > 0) {
				GameEnvironment.SwitchTo(0);
			}
		}
	}
}