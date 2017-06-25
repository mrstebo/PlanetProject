namespace PlanetProject.Core.Models
{
    public class Planet
    {
        /// <summary>
        /// The name of the planet
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Distance from the sun (km)
        /// </summary>
        public long DistanceFromSun { get; set; }

        /// <summary>
        /// The mass of the planet (10^24 kg)
        /// </summary>
        public double Mass { get; set; }

        /// <summary>
        /// The diameter of the planet (km)
        /// </summary>
        public long Diameter { get; set; }

        /// <summary>
        /// Length of day (in hours)
        /// </summary>
        public double LengthOfDay { get; set; }

        /// <summary>
        /// Orbital Period (days)
        /// </summary>
        public double OrbitalPeriod { get; set; }

        /// <summary>
        /// Orbital Velocity (km/s)
        /// </summary>
        public double OrbitalVelocity { get; set; }

        /// <summary>
        /// An image of the planet
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
