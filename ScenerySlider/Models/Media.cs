using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models {
	public abstract class Media {
		protected int id;
		protected string name;
		protected string fileLocate;
		protected string description;

		protected abstract void Play();
		protected abstract void Stop();
	}
}