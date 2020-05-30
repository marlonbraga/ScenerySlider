using Microsoft.EntityFrameworkCore;
using ScenerySlider.Models;
namespace ScenerySlider.Data {
	public class DatabaseContext: DbContext{
		public DbSet<User> Users { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Scene> Scenes { get; set; }
		public DbSet<SceneButton> SceneButtons { get; set; }
		public DbSet<InformationSpot> InformationSpots { get; set; }
		public DbSet<InformationSpotButton> InformationSpotButtons { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;User ID=DESKTOP-9TDQBPT/OverReal;Initial Catalog=ScenerySlider;Data Source=DESKTOP-9TDQBPT");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Scene>()
				.HasMany<SceneButton>(button => button.SwitchSceneButton)
				.WithOne(scene => scene.TargetScene)
				.HasForeignKey(button => button.TargetSceneId)
				.OnDelete(DeleteBehavior.NoAction);
			modelBuilder.Entity<Scene>()
				.HasMany<SceneButton>(button => button.EntryButton)
				.WithOne(scene => scene.OwnerScene)
				.HasForeignKey(button => button.OwnerSceneId)
				.OnDelete(DeleteBehavior.NoAction);
			base.OnModelCreating(modelBuilder);
		}
	}
}