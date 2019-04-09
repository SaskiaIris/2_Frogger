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
	class Fly : GameObject {
		public Fly() : base("spr_fly") {
		}

		public override void Init() {
			base.Init();
			position.X = 242;
			position.Y = 30;
		}

		public override void Update() {
			base.Update();
		}
	}
}
