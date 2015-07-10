using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Clarifi.Imaging.Host
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/frameworks/lib").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/handlebars*"));

            bundles.Add(new StyleBundle("~/Content/themes/base/media/css").Include(
                        "~/Content/themes/base/css/bootstrap-theme.css",
                        "~/Content/themes/base/css/bootstrap.css",
                        "~/Content/themes/base/css/Custom.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}