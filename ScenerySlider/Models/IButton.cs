using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenerySlider {
	interface IButton {
		string Icon { get; set; }
		int PositionX { get; set; }
		int PositionY { get; set; }
		int Rotation { get; set; }
	}
}
