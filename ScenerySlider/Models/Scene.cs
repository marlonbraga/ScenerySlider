using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Models.Context;

namespace ScenerySlider.Models {
    public class Scene {
        [Key()]
        public int Id { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        [ForeignKey("SceneChangeButton")]
        public int SceneChangeButtonId { get; set; }
        public virtual SceneChangeButton SceneButton { get; set; }
        [ForeignKey("InformationSpotButton")]
        public int InformationSpotButtonId { get; set; }
        public virtual InformationSpotButton InformationButton { get; set; }
        public void Save() {
            var context = new SceneContext();
            context.Scenes.Add(this);
            context.SaveChanges();
        }
    }
}