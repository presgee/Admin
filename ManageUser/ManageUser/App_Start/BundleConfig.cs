using System.Web.Optimization;

namespace ManageUser
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            // combines multiple files in a bundle to a single file 
            // in order to decrease the total number of request
            // that a client has to make
            // set to true in release mode, for production to enable 
            // minification and combining of files i.e using the min 
            // files of bootstrap and js files
            BundleTable.EnableOptimizations = false;

            // for external/online js scripts
            //cdn(content delivery network) - second parameter in ScriptBundle
            bundles.UseCdn = true;

            // e.g.
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval", "//ajax.googleapis.com/").Include(
            //           "~/Scripts/jquery.validate*"));
        }
    }
}
