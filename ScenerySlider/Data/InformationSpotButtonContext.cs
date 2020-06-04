﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Data {
	public class InformationSpotButtonContext:DbContext {
		// You can add custom code to this file. Changes will not be overwritten.
		// 
		// If you want Entity Framework to drop and regenerate your database
		// automatically whenever you change your model schema, please use data migrations.
		// For more information refer to the documentation:
		// http://msdn.microsoft.com/en-us/data/jj591621.aspx

		public InformationSpotButtonContext() : base("name=ScenerySlider") {
			
		}
		public System.Data.Entity.DbSet<ScenerySlider.Models.InformationSpotButton> InformationSpotButtons { get; set; }
		public System.Data.Entity.DbSet<ScenerySlider.Models.InformationSpot> InformationSpots { get; set; }
		public System.Data.Entity.DbSet<ScenerySlider.Models.Scene> Scenes { get; set; }

		public System.Data.Entity.DbSet<ScenerySlider.Models.SceneButton> SceneButtons { get; set; }
	}
}
