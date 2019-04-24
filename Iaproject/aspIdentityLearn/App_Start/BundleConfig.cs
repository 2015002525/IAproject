using System.Web;
using System.Web.Optimization;

namespace aspIdentityLearn
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundels/vendor/jquery-1.11.3.min.js").Include(
                        "~/Scripts/vendor/jquery-1.11.3.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundels/bootstrap.min.js").Include(
                        "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundels/jquery.meanmenu.js").Include(
                        "~/Scripts/jquery.meanmenu.js"));
            bundles.Add(new ScriptBundle("~/bundels/jquery.mCustomScrollbar.concat.min.js").Include(
                        "~/Scripts/jquery.mCustomScrollbar.concat.min.js"));
            bundles.Add(new ScriptBundle("~/bundels/jquerysticky").Include(
                        "~/Scripts/jquery.sticky.js"));
            bundles.Add(new ScriptBundle("~/bundels/jquery.scrollUp.min.js").Include(
                        "~/Scripts/jquery.scrollUp.min.js"));
            bundles.Add(new ScriptBundle("~/bundels/jquery.form.min.js").Include(
                        "~/Scripts/jquery.form.min.js"));
            bundles.Add(new ScriptBundle("~/bundels/jqueryvalidate").Include(
                        "~/Scripts/jquery.validate.min.js"));
            bundles.Add(new ScriptBundle("~/bundels/form-active.js").Include(
                        "~/Scripts/form-active.js"));
            bundles.Add(new ScriptBundle("~/bundels/data-table/bootstrap-table.js").Include(
                        "~/Scripts/data-table/bootstrap-table.js"));
            bundles.Add(new ScriptBundle("~/bundels/data-table/tableExport.js").Include(
                                   "~/Scripts/data-table/tableExport.js"));
            bundles.Add(new ScriptBundle("~/bundels/data-table/data-table-active.js").Include(
                       "~/Scripts/data-table/data-table-active.js"));
            bundles.Add(new ScriptBundle("~/bundels/data-table/bootstrap-table-editable.js").Include(
                        "~/Scripts/data-table/bootstrap-table-editable.js"));
            bundles.Add(new ScriptBundle("~/bundels/data-table/bootstrap-editable.js").Include(
                        "~/Scripts/data-table/bootstrap-editable.js"));
            bundles.Add(new ScriptBundle("~/bundels/data-table/bootstrap-table-resizable.js").Include(
                        "~/Scripts/data-table/bootstrap-table-resizable.js"));
            bundles.Add(new ScriptBundle("~/bundels/data-table/colResizable-1.5.source.js").Include(
                        "~/Scripts/data-table/colResizable-1.5.source.js"));
            bundles.Add(new ScriptBundle("~/bundels/data-table/bootstrap-table-export.js").Include(
                        "~/Scripts/data-table/bootstrap-table-export.js"));

                    bundles.Add(new ScriptBundle("~/bundels/main.js").Include(
                        "~/Scripts/main.js"));
            
            bundles.Add(new ScriptBundle("~/bundels/vendor/modernizr").Include(
                        "~/Scripts/vendor/modernizr-2.8.3.min.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/font-awesome.min.css",
                "~/Content/css/adminpro-custon-icon.css", 
                "~/Content/css/meanmenu.min.css",
                "~/Content/css/jquery.mCustomScrollbar.min.css",
                "~/Content/css/animate.css",
                "~/Content/css/normalize.css",
                "~/Content/css/form.css",
                "~/Content/css/data-table/bootstrap-table.css",
                "~/Content/css/data-table/bootstrap-editable.css",
                "~/Content/css/data-table/c3.min.css",
                "~/Content/css/form/all-type-forms.css",
                "~/Content/site.css",
                "~/Content/style.css",
                "~/Content/css/responsive.css"
                ));
            
        }
    }
}
