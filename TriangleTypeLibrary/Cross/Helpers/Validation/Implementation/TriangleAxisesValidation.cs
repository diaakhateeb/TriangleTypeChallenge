using TriangleTypeLibrary.Core.Enums;
using TriangleTypeLibrary.Cross.Helpers.Validation.Interfaces;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeLibrary.Cross.Helpers.Validation.Implementation
{
    /// <inheritdoc />
    /// <summary>
    /// Checks if passed values are valid for a Triangle.
    /// </summary>
    public class TriangleAxisesValidation : ITriangleAxisesValidation
    {
        /// <summary>
        /// Checks if two sides summation are greater than the third side.
        /// </summary>
        /// <param name="entity">Triangle entity object.</param>
        /// <returns>Returns error string if values are invalid.</returns>
        public string AxisesValidForTriangle(TriangleEntity entity)
        {
            if (!(entity.Length + entity.Height > entity.Base) || !(entity.Length + entity.Base > entity.Height) ||
                !(entity.Height + entity.Base > entity.Length))
                return TriangleType.Unknown + "Unknown triangle type. Triangle passed values are invalid.";
            return string.Empty;
        }
    }
}
