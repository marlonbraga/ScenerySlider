using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Data;

namespace ScenerySlider.Models {
    public class SceneButton : Button {
        [Key()]
        public int Id { get; set; }
        [ForeignKey("TargetScene")]
        public int? TargetSceneId { get; set; }
        public virtual Scene TargetScene { get; set; }
        [ForeignKey("OwnerScene")]
        public int? OwnerSceneId { get; set; }
        public virtual Scene OwnerScene { get; set; }
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