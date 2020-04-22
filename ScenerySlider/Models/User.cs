using ScenerySlider.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ScenerySlider.Models {
	public class User {
		[Key()]
		public int Id { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		
		public void Save() {
			var context = new UserContext();
			context.Users.Add(this);
			context.SaveChanges();
		}
		private void SignIn() {

		}
		private void SignOn() {

		}
		private void SignOut() {

		}
	}
}