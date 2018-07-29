using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeLibrary.Cross.Helpers.Validation.Interfaces
{
    /// <summary>
    /// Checks Triangle values interface if they can processed correctly.
    /// </summary>
    public interface INumericValidation
    {
        /// <summary>
        ///     Checks if passed Triangle values are greater than Zero.
        /// </summary>
        /// <param name="entity">Triangle entity object.</param>
        /// <returns>Returns error string if values are invalid.</returns>
        string GreaterThanZero(TriangleEntity entity);
    }
}
