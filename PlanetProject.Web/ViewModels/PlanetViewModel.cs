﻿namespace PlanetProject.Web.ViewModels
{
    public class PlanetViewModel
    {
        public string Name { get; set; }
        public double DistanceFromSun { get; set; }
        public double Mass { get; set; }
        public long Diameter { get; set; }
        public double LengthOfDay { get; set; }
        public double OrbitalPeriod { get; set; }
        public double OrbitalVelocity { get; set; }
        public string ImageUrl { get; set; }
    }
}