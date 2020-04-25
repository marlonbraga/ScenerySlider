using System;
using System.ComponentModel.DataAnnotations.Schema;
using ScenerySlider.Models;
namespace ScenerySlider {
    [NotMapped]
    public class VideoSpot:InformationSpot {
        protected override void Close() {
            throw new NotImplementedException();
        }

        protected override void Open() {
            throw new NotImplementedException();
        }
    }
}