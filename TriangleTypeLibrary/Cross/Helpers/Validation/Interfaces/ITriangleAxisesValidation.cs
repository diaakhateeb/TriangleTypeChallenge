using TriangleTypeLibrary.Core.Enums;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeLibrary.Cross.Helpers.Validation.Interfaces
{
    /// <summary>
    /// Checks if passed values are valid for a Triangle interface.
    /// </summary>
    public interface ITriangleAxisesValidation
    {
        /// <summary>
        /// Checks if two sides summation are greater than the third side.
        /// </summary>
        /// <param name="entity">Triangle entity object.</param>
        /// <returns>Returns error string if values are invalid.</returns>
        string AxisesValidForTriangle(TriangleEntity entity);
    }
}
