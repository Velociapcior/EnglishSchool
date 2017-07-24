using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using EnglishSchool.Controllers;
using System.Web.Mvc;

namespace EnglishSchool.Installers
{
    public class ControllerInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<HomeController>()
                .BasedOn<IController>()
                .LifestyleTransient());
        }
    }
}