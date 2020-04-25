using ScenerySlider.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models {
	public class InformationSpot {
		[Key()]
		public int Id { get; set; }
		public string Name { get; set; }
		public string FileLocate { get; set; }
		public string Description { get; set; }
		public void Save() {
			var context = new InformationSpotContext();
			context.InformationSpots.Add(this);
			context.SaveChanges();
		}
		protected virtual void Open(){ }
		protected virtual void Close(){ }
	}
}