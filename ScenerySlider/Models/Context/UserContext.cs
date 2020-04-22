using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models.Context {
	public class UserContext:DbContext {
		public UserContext() : base("ScenerySlider") { }
		public DbSet<User> Users { get; set; }
	}
}