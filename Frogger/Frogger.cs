using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Frogger {
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    class Frogger : GameEnvironment {
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() {
            base.LoadContent();
            screen = new Point(520, 300);
            ApplyResolutionSettings();

			gameStateList.Add(startState = new StartingState()); //0
			gameStateList.Add(playState = new PlayingState()); //1
			gameStateList.Add(winState = new WinningState()); //2
			gameStateList.Add(loseState = new LosingState()); //3
			
            GameEnvironment.SwitchTo(0);
        }

		protected override void Update(GameTime gameTime) {
			base.Update(gameTime);
		}
	}
}