using PlanetResearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetResearch
{
    public enum PlanetType
    {
        GasGiant,
        Terrestrial,
        IceGiant,
        Lava,
        Ocean
    }

    public class Planet : IPrintable
    {
        public string Name { get; set; }
        public string StarSystem { get; set; }
        public double DistanceFromEarth { get; set; } 
        public PlanetType Type { get; set; }
        public double Mass { get; set; }
        public bool HasAtmosphere { get; set; }

        public Planet(string name, string starSystem, double distance, PlanetType type, double mass, bool atmosphere)
        {
            Name = name;
            StarSystem = starSystem;
            DistanceFromEarth = distance;
            Type = type;
            Mass = mass;
            HasAtmosphere = atmosphere;
        }

        public string GetPrintableInfo()
        {
            string atmosphere = HasAtmosphere ? "Yes" : "No";
            return $"{Name} ({Type}) in {StarSystem}, {DistanceFromEarth} ly, Mass: {Mass} Earths, Atmosphere: {atmosphere}";
        }
    }
}
