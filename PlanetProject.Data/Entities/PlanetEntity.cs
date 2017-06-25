namespace PlanetProject.Data.Entities
{
    public class PlanetEntity
    {
        public long Id { get; set; }

        /// <summary>
        /// The name of the planet
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Equatorial Circumference (km)
        /// </summary>
        public long EquatorialCircumference { get; set; }

        /// <summary>
        /// Length of day (in hours)
        /// </summary>
        public double LengthOfDay { get; set; }

        /// <summary>
        /// Distance from the sun (km)
        /// </summary>
        public long DistanceFromSun { get; set; }

        /// <summary>
        /// Orbital Period (days)
        /// </summary>
        public double OrbitalPeriod { get; set; }

        /// <summary>
        /// Orbital Velocity (km/s)
        /// </summary>
        public double OrbitalVelocity { get; set; }

    }
}
