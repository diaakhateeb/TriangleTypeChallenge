using TriangleTypeLibrary.Core.Enums;

namespace TriangleTypeLibrary.Model.Interfaces
{
    /// <summary>
    /// Represents Triangle entity object interface.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        ///     Checks against triangle values and returns triangle type.
        /// </summary>
        /// <returns>Returns triangle type.</returns>
        TriangleType FindTriangle();

        /// <summary>
        ///     Triangle length axis.
        /// </summary>
        double Length { get; set; }

        /// <summary>
        ///     Triangle height axix.
        /// </summary>
        double Height { get; set; }

        /// <summary>
        ///     Triangle base axis.
        /// </summary>
        double Base { get; set; }
    }
}
