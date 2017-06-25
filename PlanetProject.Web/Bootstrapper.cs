using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using PlanetProject.Core;

namespace PlanetProject.Web
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            IoC.Configure(container);
        }
    }
}