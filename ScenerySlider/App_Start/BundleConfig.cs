using Microsoft.Ajax.Utilities;
using System.Web;
using System.Web.Optimization;

namespace ScenerySlider {
	public class BundleConfig {
		const string cdnBootstrapCss = "https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css";
		
		public static void RegisterBundles(BundleCollection bundles) {
			bundles.UseCdn = true;

			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
					"~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
					"~/Scripts/jquery.validate*"));
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
					"~/Scripts/modernizr-*"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					"~/Scripts/bootstrap.js"));
			bundles.Add(new StyleBundle("~/Content/css",cdnBootstrapCss).Include(
					"~/Content/bootstrap.css"));
			bundles.Add(new ScriptBundle("~/bundles/icons").Include(
					"~/Scripts/icons/a076d05399.js"));
			bundles.Add(new StyleBundle("~/Content/tourViewer").Include(
					"~/Content/TourFrame.css"));
			bundles.Add(new ScriptBundle("~/bundles/tour").Include(
					"~/Scripts/TourFrame/TourDragBackground.js"));

			BundleTable.EnableOptimizations = true;

		}
	}
}
