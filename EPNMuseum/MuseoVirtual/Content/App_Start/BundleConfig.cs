using System.Web.Optimization;

namespace MuseoVirtual
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").
                Include(
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/css/blog-home.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/js").
                Include(
                "~/Content/vendor/jquery/jquery.min.js",
                "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js"
                ));

        }
    }
}