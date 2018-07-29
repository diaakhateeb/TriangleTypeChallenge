using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeLibrary.Cross.Helpers.Validation.Interfaces
{
    /// <summary>
    /// Checks if Triangle values can be parsed in numbers interface.
    /// </summary>
    public interface IParseToNumberValidation
    {
        /// <summary>
        ///     Checks if passed Triangle values are numbers not string.
        /// </summary>
        /// <param name="entity">Triangle entity object.</param>
        /// <returns>Returns error string if values are invalid.</returns>
        string TryParseToNumber(TriangleEntity entity);
    }
}
