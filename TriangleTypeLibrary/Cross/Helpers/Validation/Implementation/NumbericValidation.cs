using TriangleTypeLibrary.Cross.Helpers.Validation.Interfaces;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeLibrary.Cross.Helpers.Validation.Implementation
{
    /// <inheritdoc />
    /// <summary>
    /// Checks Triangle values if they can processed correctly.
    /// </summary>
    public class NumbericValidation : INumericValidation
    {
        /// <inheritdoc />
        /// <summary>
        ///     Checks if passed Triangle values are greater than Zero.
        /// </summary>
        /// <param name="entity">Triangle entity object.</param>
        /// <returns>Returns error string if values are invalid.</returns>
        public string GreaterThanZero(TriangleEntity entity)
        {
            if (entity.Length <= 0 || entity.Height <= 0 || entity.Base <= 0)
                return ("Some Triangle values are equal or less than zero.");
            return string.Empty;
        }
    }
}
