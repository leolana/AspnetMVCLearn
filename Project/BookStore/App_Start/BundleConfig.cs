using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BookStore
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css/site").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/Site.css"
                    ));

            bundles.Add(new ScriptBundle("~/js/site").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobstrusive.js",
                        "~/Scripts/bootstrap.js"
                    ));

            BundleTable.EnableOptimizations = true;
        }
    }
}