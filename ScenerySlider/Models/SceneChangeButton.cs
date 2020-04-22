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
    public class SceneChangeButton : Button {
        [Key()]
        public int Id { get; set; }
        [ForeignKey("Scene")]
        public int SceneDestinationId { get; set; }
        public virtual Scene SceneDestination { get; set; }

        public void Save() {
            var context = new SceneChangeButtonContext();
            context.SceneChangeButtons.Add(this);
            context.SaveChanges();
        }
    }
}