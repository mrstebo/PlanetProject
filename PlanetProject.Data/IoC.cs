using Nancy.TinyIoc;
using PlanetProject.Data.Repositories;

namespace PlanetProject.Data
{
    public static class IoC
    {
        public static void Configure(TinyIoCContainer container)
        {
            container.Register<IPlanetRepository, PlanetRepository>();
        }
    }
}
