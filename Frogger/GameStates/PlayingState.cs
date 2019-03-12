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
			gameObjectList.Add(new Car("spr_dozer", new Vector2(3, 150), new Vector2(1, 0)));
        }
    }
}
