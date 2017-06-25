using System;
using System.Collections.Generic;
using System.Linq;
using PlanetProject.Data.Entities;
using PlanetProject.Data.Seeders;

namespace PlanetProject.Data.Repositories
{
    public interface IPlanetRepository
    {
        IEnumerable<PlanetEntity> All();
        PlanetEntity GetByName(string name);
    }

    internal class PlanetRepository : IPlanetRepository
    {
        private static readonly IList<PlanetEntity> PlanetData;

        static PlanetRepository()
        {
            PlanetData = new InMemoryPlanetSeeder().Seed().ToList();
        }

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
