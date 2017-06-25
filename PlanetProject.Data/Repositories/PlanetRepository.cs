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
        public IEnumerable<PlanetEntity> All()
        {
            return Enumerable.Empty<PlanetEntity>();
        }

        public PlanetEntity GetByName(string name)
        {
            return null;
        }
    }
}
