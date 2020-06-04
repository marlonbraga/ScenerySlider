using ScenerySlider.Models;
using System.Data.Entity;

namespace ScenerySlider.Data {
    public class SceneContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SceneContext() : base("name=ScenerySlider")
        {
        }
        public System.Data.Entity.DbSet<ScenerySlider.Models.Scene> Scenes { get; set; }
        public System.Data.Entity.DbSet<ScenerySlider.Models.Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Scene>()
                .HasMany<SceneButton>(button => button.SwitchSceneButton)
                .WithRequired(scene => scene.TargetScene)
                .HasForeignKey(button => button.TargetSceneId);
            modelBuilder.Entity<Scene>()
                .HasMany<SceneButton>(button => button.EntryButton)
                .WithRequired(scene => scene.OwnerScene)
                .HasForeignKey(button => button.OwnerSceneId);
        }
    }
}