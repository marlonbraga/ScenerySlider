using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Data;

namespace ScenerySlider.Models {
    public class SceneChangeButton : Button {
        [Key()]
        public int Id { get; set; }
        //[ForeignKey("Scene")]
        //public int SceneTarget { get; set; }
        [ForeignKey("Scene")]
        public int SceneId { get; set; }
        public virtual Scene Scene { get; set; }
        public override string Icon { get; set; }
        public override int PositionX { get; set; }
        public override int PositionY { get; set; }
        public override int Rotation { get; set; }
        public void Save() {
            var context = new DatabaseContext();
            context.SceneChangeButtons.Add(this);
            context.SaveChanges();
        }
    }
}