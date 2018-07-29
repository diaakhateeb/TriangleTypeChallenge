using TriangleTypeLibrary.Core.Enums;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeLibrary.Core.Interfaces.Repository
{
    /// <summary>
    /// Repository interface to provide Triangle services.
    /// </summary>
    public interface ITriangleRepository
    {
        /// <summary>
        ///     Validates passed triangle values.
        /// </summary>
        /// <returns>Returns true if values are valid. Otherwise, returns false.</returns>
        string ValidateTriangleValues();

        /// <summary>
        ///     Checks against triangle values and returns triangle type.
        /// </summary>
        /// <returns>Returns triangle type.</returns>
        TriangleType GetTriangleType();

        /// <summary>
        /// Triangle entity property.
        /// </summary>
        TriangleEntity TriangleEntity { get; set; }
    }
}
