using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models.Context {
	public class InformationSpotButtonContext :DbContext {
		public InformationSpotButtonContext() : base("ScenerySlider") { }
		public DbSet<InformationSpotButton> InformationSpotButtons { get; set; }
	}
}