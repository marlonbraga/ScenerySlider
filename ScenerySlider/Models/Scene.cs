using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Data;

namespace ScenerySlider.Models {
    public class Scene {
        [Key()]
        public int Id { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        [ForeignKey("InformationSpotButton")]
        public int InformationSpotButtonId { get; set; }
        public virtual InformationSpotButton InformationSpotButton { get; set; }
        public void Save() {
            var context = new DatabaseContext();
            context.Scenes.Add(this);
            context.SaveChanges();
        }
    }
}