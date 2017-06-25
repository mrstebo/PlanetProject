using System.Collections.Generic;
using PlanetProject.Data.Entities;

namespace PlanetProject.Data.Seeders
{
    public interface IPlanetSeeder
    {
        IEnumerable<PlanetEntity> Seed();
    }
}