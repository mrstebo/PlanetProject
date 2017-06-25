namespace PlanetProject.Web.ViewModels
{
    public class PlanetViewModel
    {
        public string Name { get; set; }
        public long DistanceFromSun { get; set; }
        public double Mass { get; set; }
        public long Diameter { get; set; }
        public double LengthOfDay { get; set; }
        public double OrbitalPeriod { get; set; }
        public double OrbitalVelocity { get; set; }
    }
}