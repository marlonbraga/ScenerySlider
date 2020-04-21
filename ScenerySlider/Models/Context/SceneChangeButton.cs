using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.Entity;

namespace ScenerySlider.Models {
    public class SceneChangeButton : DbContext, IButton {
        public SceneChangeButton() : base("ScenerySlider") { }
        public DbSet<SceneChangeButton> All { get; set; }

        private Scene sceneDestination;
        private int id { get; set; }
        int IButton.positionX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IButton.positionY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Save() {
            this.All.Add(this);
            this.SaveChanges();
        }
    }
}