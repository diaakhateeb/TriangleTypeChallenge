using System;
using System.Linq;
using TriangleTypeLibrary.Core.Enums;
using TriangleTypeLibrary.Model.Interfaces;

namespace TriangleTypeLibrary.Model.Entities
{
    /// <inheritdoc />
    /// <summary>
    ///     Triangle entity class.
    /// </summary>
    public class TriangleEntity : IEntity
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets Triangle type.
        /// </summary>
        /// <returns>Returns TriangleType enum value.</returns>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="Exception"></exception>
        public TriangleType FindTriangle()
        {
            try
            {
                double[] triaArray = {Length, Height, Base};

                var valsCount = triaArray.Distinct().Count();

                return valsCount == 1
                    ? TriangleType.Equilateral
                    : valsCount == 2
                        ? TriangleType.Isosceles
                        : valsCount == 3
                            ? TriangleType.Scalene
                            : TriangleType.Unknown;
            }
            catch (InvalidOperationException invalOperaEx)
            {
                throw invalOperaEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     Triangle length axis.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        ///     Triangle height axis.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        ///     Triangle base axis.
        /// </summary>
        public double Base { get; set; }
    }
}