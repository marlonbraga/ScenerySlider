using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ScenerySlider.Models   {
	public class Project:DbContext {
		public Project() : base("ScenerySlider") { }
		public DbSet<Project> All { get; set; }



		private int id { get; set; }
		private User user { get; set; }
		public void Save() {
			this.All.Add(this);
			this.SaveChanges();
		}
		private void Delete() {

		}
	}
}