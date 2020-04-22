using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models.Context {
	public class ProjectContext :DbContext {
		public ProjectContext() : base("ScenerySlider") { }
		public DbSet<Project> Projects { get; set; }
	}
}