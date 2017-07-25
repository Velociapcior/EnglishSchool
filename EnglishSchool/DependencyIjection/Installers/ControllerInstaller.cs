using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace EnglishSchool.DependencyInjection.Installers
{
  public class ControllersInstaller : IWindsorInstaller
  {
    [ExcludeFromCodeCoverage]
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
      container.Register(
        Classes.FromThisAssembly()
        .BasedOn<Controller>()
        .LifestyleTransient());
    }
  }
}