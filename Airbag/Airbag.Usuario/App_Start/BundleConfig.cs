using System.Web;
using System.Web.Optimization;

namespace Airbag.Usuario
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
              //        "~/Scripts/bootstrap.js"));

            //bundles.Add(new ScriptBundle("~/bundles/custom").Include(
              //        "~/Scripts/custom.js"));


            
            bundles.Add(new StyleBundle("~/styles/css").Include(
                      "~/styles/bootstrap.min.css",
                      "~/styles/fontawesome-all.css",
                      "~/styles/owl.carousel.css",
                      "~/styles/owl.carousel.css",
                      "~/styles/owl.theme.default.css",
                      "~/styles/animate.css",
                      "~/styles/slick.css",
                      "~/styles/main_styles.css",
                      "~/styles/responsive.css"));
                      
        }
    }
}
