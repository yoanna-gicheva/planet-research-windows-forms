using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Йоанна Милкова Гичева, F090350
/// </summary>
namespace PlanetResearch.Interfaces
{
    /// <summary>
    /// Представлява планета с основни астрономически свойства.
    /// </summary>
    public interface IPlanet
    {
        /// <summary>
        /// Името на планетата.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Името на звездната система, в която се намира планетата.
        /// </summary>
        string StarSystem { get; set; }

        /// <summary>
        /// Разстоянието от Земята в светлинни години.
        /// </summary>
        double DistanceFromEarth { get; set; }

        /// <summary>
        /// Типът на планетата (например GasGiant, Terrestrial и т.н.).
        /// </summary>
        PlanetType Type { get; set; }

        /// <summary>
        /// Масата на планетата в сравнение с масата на Земята.
        /// </summary>
        double Mass { get; set; }

        /// <summary>
        /// Указва дали планетата има атмосфера.
        /// </summary>
        bool HasAtmosphere { get; set; }
    }
}
