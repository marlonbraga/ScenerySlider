using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Data;

namespace ScenerySlider.Models {
    public class Scene {
        [Key()]
        public int SceneId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string BackgroundLocation { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        [ForeignKey("TargetSceneId")]
        public virtual ICollection<SceneButton> SwitchSceneButton { get; set; }
        [ForeignKey("OwnerSceneId")]
        public virtual ICollection<SceneButton> EntryButton { get; set; }
        public virtual ICollection<InformationSpotButton> InformationSpotButton { get; set; }

        public void Save() {
            var context = new DatabaseContext();
            context.Scenes.Add(this);
            context.SaveChanges();
        }
    }
}