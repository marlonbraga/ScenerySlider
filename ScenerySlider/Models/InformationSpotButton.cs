using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using ScenerySlider.Models;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Models.Context;

namespace ScenerySlider.Models {
    public class InformationSpotButton: Button {
        
        [Key()]
        private int Id { get; set; }
        [ForeignKey("InformationSpot")]
        public int InformationId { get; set; }
        public virtual InformationSpot Information { get; set; }
        public void Save() {
            var context = new InformationSpotButtonContext();
            context.InformationSpotButtons.Add(this);
            context.SaveChanges();
        }
    }

}