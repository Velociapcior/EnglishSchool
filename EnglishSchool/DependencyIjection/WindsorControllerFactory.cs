using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using Castle.Windsor;

namespace EnglishSchool.DependencyInjection
{
  [ExcludeFromCodeCoverage]
  public class WindsorControllerFactory : DefaultControllerFactory
  {
    private readonly IWindsorContainer _container;

    public WindsorControllerFactory(IWindsorContainer container)
    {
      _container = container;
    }

    public override void ReleaseController(IController controller)
    {
      _container.Release(controller);
    }

    protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
    {
      if (controllerType == null)
      {
        return null;
      }

      return _container.Resolve(controllerType) as IController;
    }
  }
}