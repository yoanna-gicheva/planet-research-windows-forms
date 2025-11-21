using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetResearch.Repositories
{
    public delegate int PlanetComparison(Planet p1, Planet p2);

    public class PlanetRepository
    {
        private List<Planet> planets = new List<Planet>();

        public void AddPlanet(Planet p)
        {
            planets.Add(p);
        }


        public void RemovePlanet(Planet p)
        {
            planets.Remove(p);
        }

        public List<Planet> GetAll()
        {
            return planets;
        }

        public Planet FindByName(string name)
        {
            return planets.Find(p => p.Name.ToLower() == name.ToLower());
        }

        public void Sort(PlanetComparison comparison)
        {
            planets.Sort((a, b) => comparison(a, b));
        }
    }
}
