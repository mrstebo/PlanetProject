using Nancy.TinyIoc;
using PlanetProject.Core.Services;

namespace PlanetProject.Core
{
    public static class IoC
    {
        public static void Configure(TinyIoCContainer container)
        {
            container.Register<IPlanetService, PlanetService>();

            Data.IoC.Configure(container);
        }
    }
}
