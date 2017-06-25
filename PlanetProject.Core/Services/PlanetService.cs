using System.Collections.Generic;
using System.Linq;
using PlanetProject.Core.Models;
using PlanetProject.Data.Entities;
using PlanetProject.Data.Repositories;

namespace PlanetProject.Core.Services
{
    public interface IPlanetService
    {
        IEnumerable<Planet> GetAll();
        Planet GetByName(string name);
    }

    internal class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;
        
        public PlanetService(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public IEnumerable<Planet> GetAll()
        {
            return _planetRepository.All().Select(ConvertToPlanet);
        }

        public Planet GetByName(string name)
        {
            var entity = _planetRepository.GetByName(name);

            return entity == null ? null : ConvertToPlanet(entity);
        }

        private static Planet ConvertToPlanet(PlanetEntity entity)
        {
            return new Planet
            {
                Name = entity.Name,
                EquatorialCircumference = entity.EquatorialCircumference,
                LengthOfDay = entity.LengthOfDay,
                DistanceFromSun = entity.DistanceFromSun,
                OrbitalPeriod = entity.OrbitalPeriod,
                OrbitalVelocity = entity.OrbitalVelocity
            };
        }
    }
}
