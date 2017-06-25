using System;
using System.Collections.Generic;
using System.Linq;
using PlanetProject.Data.Entities;

namespace PlanetProject.Data.Repositories
{
    public interface IPlanetRepository
    {
        IEnumerable<PlanetEntity> All();
        PlanetEntity GetByName(string name);
    }

    internal class PlanetRepository : IPlanetRepository
    {
        private static readonly IList<PlanetEntity> PlanetData = new[]
        {
            new PlanetEntity
            {
                Id = 1,
                Name = "Mercury",
                EquatorialCircumference = 15329,
                LengthOfDay = 4222.6,
                DistanceFromSun = 57909227,
                OrbitalPeriod = 88.0,
                OrbitalVelocity = 47.4
            },
            new PlanetEntity
            {
                Id = 2,
                Name = "Venus",
                EquatorialCircumference = 38024,
                LengthOfDay = 2802,
                DistanceFromSun = 108209475,
                OrbitalPeriod = 224.7,
                OrbitalVelocity = 35.0
            },
            new PlanetEntity
            {
                Id = 3,
                Name = "Earth",
                EquatorialCircumference = 40030,
                LengthOfDay = 24,
                DistanceFromSun = 149598262,
                OrbitalPeriod = 365.2,
                OrbitalVelocity = 29.8
            },
            new PlanetEntity
            {
                Id = 4,
                Name = "Mars",
                EquatorialCircumference = 21296,
                LengthOfDay = 24.7,
                DistanceFromSun = 227943824,
                OrbitalPeriod = 687.0,
                OrbitalVelocity = 24.1
            },
            new PlanetEntity
            {
                Id = 5,
                Name = "Jupiter",
                EquatorialCircumference = 0,
                LengthOfDay = 9.9,
                DistanceFromSun = 778340821,
                OrbitalPeriod = 4331,
                OrbitalVelocity = 13.1
            },
            new PlanetEntity
            {
                Id = 6,
                Name = "Saturn",
                EquatorialCircumference = 0,
                LengthOfDay = 10.7,
                DistanceFromSun = 1426666422,
                OrbitalPeriod = 10747,
                OrbitalVelocity = 9.7
            },
            new PlanetEntity
            {
                Id = 7,
                Name = "Uranus",
                EquatorialCircumference = 0,
                LengthOfDay = 17.2,
                DistanceFromSun = 2870658186,
                OrbitalPeriod = 30589,
                OrbitalVelocity = 6.8
            },
            new PlanetEntity
            {
                Id = 8,
                Name = "Neptune",
                EquatorialCircumference = 0,
                LengthOfDay = 16.1,
                DistanceFromSun = 4498396441,
                OrbitalPeriod = 59800,
                OrbitalVelocity = 5.4
            }
        };

        public IEnumerable<PlanetEntity> All()
        {
            return PlanetData;
        }

        public PlanetEntity GetByName(string name)
        {
            return PlanetData.FirstOrDefault(x => string.Equals(name, x.Name, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
