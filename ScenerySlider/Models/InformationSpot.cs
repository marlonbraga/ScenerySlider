using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models {
	public abstract class InformationSpot {
		protected int id;
		protected string name;
		protected string fileLocate;
		protected string description;

		protected abstract void Open();
		protected abstract void Close();
	}
}