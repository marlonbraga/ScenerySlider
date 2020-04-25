using Microsoft.EntityFrameworkCore;

namespace ScenerySlider.Models.Context {
	public class DatabaseContext : DbContext{
		public DbSet<User> Users { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Scene> Scenes { get; set; }
		public DbSet<SceneChangeButton> SceneChangeButtons { get; set; }
		public DbSet<InformationSpot> InformationSpots { get; set; }
		public DbSet<InformationSpotButton> InformationSpotButtons { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;User ID=DESKTOP-9TDQBPT/OverReal;Initial Catalog=ScenerySlider;Data Source=DESKTOP-9TDQBPT");
		}
	}
}