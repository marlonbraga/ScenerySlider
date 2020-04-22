using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models.Context {
	public class SceneContext:DbContext {
		public SceneContext() : base("ScenerySlider") { }
		public DbSet<Scene> Scenes { get; set; }
	}
}