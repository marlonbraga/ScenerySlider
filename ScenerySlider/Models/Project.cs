using ScenerySlider.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScenerySlider.Models {
	public class Project {
		[Key()]
		public int Id { get; set; }
		[ForeignKey("User")]
		public int UserId { get; set; }
		public virtual User User { get; set; }
		public string Name { get; set; }
		
		public void Save() {
			var context = new DatabaseContext();
			context.Projects.Add(this);
			context.SaveChanges();
		}
		private void Delete() {

		}
	}
}