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
    /// Интерфейс за обекти, които могат да предоставят текстова информация за печат или показване.
    /// </summary>
    public interface IPrintable
    {
        /// <summary>
        /// Връща текстова информация за обекта, която може да бъде показана или отпечатана.
        /// </summary>
        /// <returns>Подробна текстова информация за обекта.</returns>
        string GetPrintableInfo();
    }
}
