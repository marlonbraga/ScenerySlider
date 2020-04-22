using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models.Context {
	public class SceneChangeButtonContext : DbContext {
		public SceneChangeButtonContext() : base("ScenerySlider") { }
		public DbSet<SceneChangeButton> SceneChangeButtons { get; set; }
	}
}