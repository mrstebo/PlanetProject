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
                DistanceFromSun = 57.9,
                Mass = 0.330,
                Diameter =  4879,
                LengthOfDay = 4222.6,
                OrbitalPeriod = 88.0,
                OrbitalVelocity = 47.4,
                ImageUrl = "https://nssdc.gsfc.nasa.gov/planetary/banner/mercury.gif"
            },
            new PlanetEntity
            {
                Id = 2,
                Name = "Venus",
                DistanceFromSun = 108.2,
                Mass = 4.87,
                Diameter =  12104,
                LengthOfDay = 2802,
                OrbitalPeriod = 224.7,
                OrbitalVelocity = 35.0,
                ImageUrl = "https://nssdc.gsfc.nasa.gov/planetary/banner/venus.gif"
            },
            new PlanetEntity
            {
                Id = 3,
                Name = "Earth",
                DistanceFromSun = 149.6,
                Mass = 5.97,
                Diameter =  12756,
                LengthOfDay = 24,
                OrbitalPeriod = 365.2,
                OrbitalVelocity = 29.8,
                ImageUrl = "https://nssdc.gsfc.nasa.gov/planetary/banner/earth.gif"
            },
            new PlanetEntity
            {
                Id = 4,
                Name = "Mars",
                DistanceFromSun = 227.9,
                Mass = 0.642,
                Diameter =  6792,
                LengthOfDay = 24.7,
                OrbitalPeriod = 687.0,
                OrbitalVelocity = 24.1,
                ImageUrl = "https://nssdc.gsfc.nasa.gov/planetary/banner/mars.gif"
            },
            new PlanetEntity
            {
                Id = 5,
                Name = "Jupiter",
                DistanceFromSun = 778.6,
                Mass = 1898,
                Diameter =  142984,
                LengthOfDay = 9.9,
                OrbitalPeriod = 4331,
                OrbitalVelocity = 13.1,
                ImageUrl = "https://nssdc.gsfc.nasa.gov/planetary/banner/jupiter.gif"
            },
            new PlanetEntity
            {
                Id = 6,
                Name = "Saturn",
                DistanceFromSun = 1433.5,
                Mass = 568,
                Diameter =  120536,
                LengthOfDay = 10.7,
                OrbitalPeriod = 10747,
                OrbitalVelocity = 9.7,
                ImageUrl = "https://nssdc.gsfc.nasa.gov/planetary/banner/saturn.gif"
            },
            new PlanetEntity
            {
                Id = 7,
                Name = "Uranus",
                DistanceFromSun = 2872.5,
                Mass = 86.8,
                Diameter =  51118,
                LengthOfDay = 17.2,
                OrbitalPeriod = 30589,
                OrbitalVelocity = 6.8,
                ImageUrl = "https://nssdc.gsfc.nasa.gov/planetary/banner/uranus.gif"
            },
            new PlanetEntity
            {
                Id = 8,
                Name = "Neptune",
                DistanceFromSun = 4495.1,
                Mass = 102,
                Diameter =  49528,
                LengthOfDay = 16.1,
                OrbitalPeriod = 59800,
                OrbitalVelocity = 5.4,
                ImageUrl = "https://nssdc.gsfc.nasa.gov/planetary/banner/neptune.gif"
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
