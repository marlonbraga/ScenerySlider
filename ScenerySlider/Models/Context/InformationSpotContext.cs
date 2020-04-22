using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models.Context {
	public class InformationSpotContext : DbContext{
		public InformationSpotContext() : base("ScenerySlider") { }
		public DbSet<InformationSpot> InformationSpots { get; set; }
	}
}