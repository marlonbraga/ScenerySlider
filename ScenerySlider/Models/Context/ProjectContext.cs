﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScenerySlider.Models.Context {
	public class ProjectContext :DbContext {
		//public ProjectContext() : base("ScenerySlider") { }
		public DbSet<Project> Projects { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;User ID=DESKTOP-9TDQBPT/OverReal;Initial Catalog=ScenerySlider;Data Source=DESKTOP-9TDQBPT");
		}
	}
}