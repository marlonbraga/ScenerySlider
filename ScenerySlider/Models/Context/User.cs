using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models {
	public class User:DbContext {
		public User() : base("ScenerySlider") {}
		public DbSet<User> All { get; set; }
		public int id { get; set; }
		public string login { get; set; }
		public string password { get; set; }
		public void Save() {
			this.All.Add(this);
			this.SaveChanges();
		}
		private void SignIn() {

		}
		private void SignOn() {

		}
		private void SignOut() {

		}
	}
}