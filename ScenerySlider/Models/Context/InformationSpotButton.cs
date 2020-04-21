using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using ScenerySlider.Models;
using System.Data.Entity;

namespace ScenerySlider.Models {
    public class InformationSpotButton: DbContext, IButton {
        public InformationSpotButton() : base("ScenerySlider") { }
        public DbSet<InformationSpotButton> All { get; set; }

        private InformationSpot information;
        private int id { get; set; }
        int IButton.positionX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IButton.positionY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Save() {
            this.All.Add(this);
            this.SaveChanges();
        }

    }

}