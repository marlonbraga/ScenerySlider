using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Data;

namespace ScenerySlider.Models {
    public class Scene {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BackgroundLocation { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        
        //TODO-1:List of info spots 
        public List<SceneChangeButton> SceneChangeButtons;
        //TODO-2:List of scene spots 
        public List<InformationSpotButton> InformationSpotButtons;

        //[ForeignKey("InformationSpotButton")]
        //public int InformationSpotButtonId { get; set; }
        //public virtual InformationSpotButton InformationSpotButton { get; set; }
        
        public void Save() {
            var context = new DatabaseContext();
            context.Scenes.Add(this);
            context.SaveChanges();
        }
    }
}