using PlanetResearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Йоанна Милкова Гичева, F090350
/// </summary>
namespace PlanetResearch
{
    /// <summary>
    /// Типове планети, използвани за класификация в системата.
    /// </summary>
    public enum PlanetType
    {
        /// <summary>
        /// Газов гигант, като Юпитер или Сатурн.
        /// </summary>
        GasGiant,

        /// <summary>
        /// Земеподобна планета с твърда повърхност.
        /// </summary>
        Terrestrial,

        /// <summary>
        /// Леден гигант, като Уран или Нептун.
        /// </summary>
        IceGiant,

        /// <summary>
        /// Лавова планета с гореща повърхност.
        /// </summary>
        Lava,

        /// <summary>
        /// Планета с обширни океани.
        /// </summary>
        Ocean
    }

    /// <summary>
    /// Представя планета с базови свойства като име, система, маса и атмосфера.
    /// Реализира интерфейсите <see cref="IPlanet"/> и <see cref="IPrintable"/>.
    /// </summary>
    public class IPlanet : Interfaces.IPlanet, IPrintable
    {
        /// <summary>
        /// Името на планетата.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Звездната система, в която се намира планетата.
        /// </summary>
        public string StarSystem { get; set; }

        /// <summary>
        /// Разстоянието от Земята в светлинни години.
        /// </summary>
        public double DistanceFromEarth { get; set; }

        /// <summary>
        /// Типът на планетата (например Газов гигант, Земеподобна и т.н.).
        /// </summary>
        public PlanetType Type { get; set; }

        /// <summary>
        /// Масата на планетата в еквивалент на Земята.
        /// </summary>
        public double Mass { get; set; }

        /// <summary>
        /// Показва дали планетата има атмосфера.
        /// </summary>
        public bool HasAtmosphere { get; set; }

        /// <summary>
        /// Инициализира нов обект <see cref="IPlanet"/> с всички основни свойства.
        /// </summary>
        /// <param name="name">Името на планетата.</param>
        /// <param name="starSystem">Звездната система на планетата.</param>
        /// <param name="distance">Разстояние от Земята в светлинни години.</param>
        /// <param name="type">Типът на планетата.</param>
        /// <param name="mass">Масата на планетата в еквивалент на Земята.</param>
        /// <param name="atmosphere">Дали планетата има атмосфера.</param>
        public IPlanet(string name, string starSystem, double distance, PlanetType type, double mass, bool atmosphere)
        {
            Name = name;
            StarSystem = starSystem;
            DistanceFromEarth = distance;
            Type = type;
            Mass = mass;
            HasAtmosphere = atmosphere;
        }

        /// <summary>
        /// Връща информация за планетата под формата на текст, подходящ за печат.
        /// </summary>
        /// <returns>Стринг с името, типа, системата, разстоянието, масата и наличието на атмосфера.</returns>
        public string GetPrintableInfo()
        {
            string atmosphere = HasAtmosphere ? "Yes" : "No";
            return $"{Name} ({Type}) in {StarSystem}, {DistanceFromEarth} ly, Mass: {Mass} Earths, Atmosphere: {atmosphere}";
        }
    }
}
