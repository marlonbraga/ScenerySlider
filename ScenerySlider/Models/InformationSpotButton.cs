﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Data;

namespace ScenerySlider.Models {
    public class InformationSpotButton: Button {
        [Key()]
        public int Id { get; set; }
        [ForeignKey("InformationSpot")]
        public int InformationSpotId { get; set; }
        public virtual InformationSpot InformationSpot { get; set; }
        public override int PositionX { get; set; }
        public override int PositionY { get; set; }
        public void Save() {
            var context = new DatabaseContext();
            context.InformationSpotButtons.Add(this);
            context.SaveChanges();
        }
    }
}