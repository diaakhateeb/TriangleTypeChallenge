using System.Globalization;
using TriangleTypeLibrary.Cross.Helpers.Validation.Interfaces;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeLibrary.Cross.Helpers.Validation.Implementation
{
    /// <summary>
    /// Checks if Triangle values can be parsed in numbers.
    /// </summary>
    public class ParseToNumberValidation : IParseToNumberValidation
    {
        /// <inheritdoc />
        /// <summary>
        ///     Checks if passed Triangle values are numbers not string.
        /// </summary>
        /// <param name="entity">Triangle entity object.</param>
        /// <returns>Returns error string if values are invalid.</returns>
        public string TryParseToNumber(TriangleEntity entity)
        {
            if (!double.TryParse(entity.Length.ToString(CultureInfo.InvariantCulture), out var lengthResult) ||
                !double.TryParse(entity.Height.ToString(CultureInfo.InvariantCulture), out var heightResult) ||
                !double.TryParse(entity.Base.ToString(CultureInfo.InvariantCulture), out var baseResult))
                return "Some Triangle values can not be processed as numbers";
            return "";
        }
    }
}
