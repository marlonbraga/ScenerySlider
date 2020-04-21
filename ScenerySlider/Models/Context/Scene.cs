using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.Entity;

namespace ScenerySlider.Models {
    public class Scene : DbContext {
        public Scene() : base("ScenerySlider") { }
        public DbSet<Scene> All { get; set; }



        private int id { get; set; }
        private Project project { get; set; }
        private SceneChangeButton sceneButton { get; set; }
        private InformationSpotButton informationButton { get; set; }
        public void Save() {
            this.All.Add(this);
            this.SaveChanges();
        }
    }
}