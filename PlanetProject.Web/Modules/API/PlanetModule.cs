using System.Linq;
using Nancy;
using PlanetProject.Core.Models;
using PlanetProject.Core.Services;
using PlanetProject.Web.ViewModels;

namespace PlanetProject.Web.Modules.API
{
    public class PlanetModule : NancyModule
    {
        private readonly IPlanetService _planetService;

        public PlanetModule(IPlanetService planetService)
            : base("/api/planets")
        {
            _planetService = planetService;

            Get["/"] = _ => GetPlanets();
            Get["/{name}"] = args => GetPlanet(args.name);
        }

        private dynamic GetPlanets()
        {
            var planets = _planetService.GetAll().Select(ConvertPlanetToViewModel);

            return Response.AsJson(planets);
        }

        private dynamic GetPlanet(string name)
        {
            var planet = _planetService.GetByName(name);

            return planet == null
                ? new NotFoundResponse()
                : Response.AsJson(planet);
        }

        private static PlanetViewModel ConvertPlanetToViewModel(Planet planet)
        {
            return new PlanetViewModel
            {
                Name = planet.Name,
                DistanceFromSun = planet.DistanceFromSun,
                Mass = planet.Mass,
                Diameter = planet.Diameter,
                LengthOfDay = planet.LengthOfDay,
                OrbitalPeriod = planet.OrbitalPeriod,
                OrbitalVelocity = planet.OrbitalVelocity
            };
        }
    }
}