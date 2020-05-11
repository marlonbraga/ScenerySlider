﻿using ScenerySlider.Data;
using System;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ScenerySlider {
	public class MvcApplication:System.Web.HttpApplication {
		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			BundleTable.EnableOptimizations = true;

			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SceneContext>());
		}

		private void RegisterRoutes(RouteCollection routes) {
			throw new NotImplementedException();
		}
	}
}
