using Castle.Windsor;
using Castle.Windsor.Installer;
using EnglishSchool.DependencyInjection;
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

      WindsorControllerFactory windsorControllerFactory = CreateWindsorControllerFactory();
      ControllerBuilder.Current.SetControllerFactory(windsorControllerFactory);
    }

    private WindsorControllerFactory CreateWindsorControllerFactory()
    {
      WindsorContainer container = new WindsorContainer();
      container.Install(FromAssembly.This());

      WindsorControllerFactory result = new WindsorControllerFactory(container);

      return result;
    }
  }
}
