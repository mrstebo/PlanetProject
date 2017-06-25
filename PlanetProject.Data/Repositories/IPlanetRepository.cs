using System.Collections.Generic;
using PlanetProject.Data.Entities;

namespace PlanetProject.Data.Repositories
{
    public interface IPlanetRepository
    {
        IEnumerable<PlanetEntity> All();
        PlanetEntity GetByName(string name);
    }
}
