using Castle.Windsor;
using Castle.Windsor.Installer;
using EnglishSchool.Installers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EnglishSchool
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IWindsorContainer container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IocContainer.Setup();
        }

        protected void Application_End()
        {
            container.Dispose();
        }
    }
}
