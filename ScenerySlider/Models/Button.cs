using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models {
	public abstract class Button {
		public virtual string Icon { get; set; }
		public virtual int PositionX{ get; set; }
		public virtual int PositionY { get; set; }
		public virtual int Rotation { get; set; }
	}
}