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
	public class Project {
		[Key()]
		public int Id { get; set; }
		[ForeignKey("User")]
		public int UserId { get; set; }
		public virtual User User { get; set; }
		
		public void Save() {
			var context = new ProjectContext();
			context.Projects.Add(this);
			context.SaveChanges();
		}
		private void Delete() {

		}
	}
}