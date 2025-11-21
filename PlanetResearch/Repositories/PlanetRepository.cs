using PlanetResearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Йоанна Милкова Гичева, F090350
/// </summary>
namespace PlanetResearch.Repositories
{
    /// <summary>
    /// Делегат за сравнение на два обекта от тип <see cref="IPlanet"/>.
    /// Използва се при сортиране на списък с планети.
    /// </summary>
    /// <param name="p1">Първата планета за сравнение.</param>
    /// <param name="p2">Втората планета за сравнение.</param>
    /// <returns>Цяло число, което определя реда на планетите (подобно на <see cref="IComparer{T}"/>).</returns>
    public delegate int PlanetComparison(Interfaces.IPlanet p1, Interfaces.IPlanet p2);

    /// <summary>
    /// Репозитори за управление на колекция от планети.
    /// Позволява добавяне, премахване, търсене и сортиране на планети.
    /// </summary>
    public class PlanetRepository
    {
        private List<Interfaces.IPlanet> planets = new List<Interfaces.IPlanet>();

        /// <summary>
        /// Добавя нова планета към репозитория.
        /// </summary>
        /// <param name="p">Обект от тип <see cref="IPlanet"/>, който ще бъде добавен.</param>
        public void AddPlanet(Interfaces.IPlanet p)
        {
            planets.Add(p);
        }

        /// <summary>
        /// Премахва дадена планета от репозитория.
        /// </summary>
        /// <param name="p">Обект от тип <see cref="IPlanet"/>, който ще бъде премахнат.</param>
        public void RemovePlanet(Interfaces.IPlanet p)
        {
            planets.Remove(p);
        }

        /// <summary>
        /// Връща списък с всички планети в репозитория.
        /// </summary>
        /// <returns>Списък от обекти <see cref="IPlanet"/>.</returns>
        public List<Interfaces.IPlanet> GetAll()
        {
            return planets;
        }

        /// <summary>
        /// Намира планета по нейното име.
        /// </summary>
        /// <param name="name">Името на планетата за търсене (не се прави разлика между главни и малки букви).</param>
        /// <returns>Обект <see cref="IPlanet"/> ако е намерен; иначе <c>null</c>.</returns>
        public Interfaces.IPlanet FindByName(string name)
        {
            return planets.Find(p => p.Name.ToLower() == name.ToLower());
        }

        /// <summary>
        /// Сортира планетите в репозитория по зададено сравнение.
        /// </summary>
        /// <param name="comparison">Метод за сравнение, който определя реда на планетите.</param>
        public void Sort(PlanetComparison comparison)
        {
            planets.Sort((a, b) => comparison(a, b));
        }
    }
}
