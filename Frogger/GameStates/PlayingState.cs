using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Frogger {
	class PlayingState : GameState {
		public PlayingState() {
			gameObjectList.Add(new GameObject("spr_background"));
			gameObjectList.Add(new Frog());
			//gameObjectList.Add(new Car("spr_dozer", new Vector2(3, 150), new Vector2(1, 0)));

			for(int i = 0; i < 3; i++) {
				gameObjectList.Add(new Car("spr_truck", new Vector2(70 + i * 150, 225), new Vector2(-2, 0)));
				gameObjectList.Add(new Car("spr_dozer", new Vector2(70 + i * 150, 185), new Vector2(2, 0)));
				gameObjectList.Add(new Car("spr_racecar", new Vector2(70 + i * 150, 145), new Vector2(-2, 0)));
			}
		}

		public override void Update(GameTime gameTime) {
			base.Update(gameTime);

			foreach(GameObject gameObject in gameObjectList) {
				if(gameObject is Frog) {
					foreach(GameObject gameObject2 in gameObjectList) {
						if(gameObject2 is Car) {
							if(gameObject.Overlaps(gameObject2)){
								gameObject.Init();
							}
						}
					}
				}
			}
		}
	}
}