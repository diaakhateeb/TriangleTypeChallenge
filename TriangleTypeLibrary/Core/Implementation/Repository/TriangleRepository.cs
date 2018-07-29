using System;
using TriangleTypeLibrary.Core.Enums;
using TriangleTypeLibrary.Core.Interfaces.Repository;
using TriangleTypeLibrary.Cross.Helpers.Validation.Interfaces;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeLibrary.Core.Implementation.Repository
{
    /// <inheritdoc />
    /// <summary>
    ///     Repository class to provide Triangle services.
    /// </summary>
    public class TriangleRepository : ITriangleRepository
    {
        //private readonly IInputValidation _validation;
        private readonly INumericValidation _numValidation;
        private readonly IParseToNumberValidation _parseNumberValidation;
        private readonly ITriangleAxisesValidation _triangleAxisesValidation;

        /// <summary>
        /// Instantiates TriangleRepository object.
        /// </summary>
        /// <param name="numericValidationObj"></param>
        /// <param name="parseToNumberValidationObj"></param>
        /// <param name="triangleAxisesValidationObj"></param>
        /// <exception cref="System.ArgumentNullException">Throws when inputValidation objectis not initialized.</exception>
        public TriangleRepository(INumericValidation numericValidationObj, 
            IParseToNumberValidation parseToNumberValidationObj, ITriangleAxisesValidation triangleAxisesValidationObj)
        {
            try
            {
                if(numericValidationObj == null || parseToNumberValidationObj == null || triangleAxisesValidationObj == null)
                    throw new ArgumentNullException("Some validation objects are null.");

                _numValidation = numericValidationObj;
                _parseNumberValidation = parseToNumberValidationObj;
                _triangleAxisesValidation = triangleAxisesValidationObj;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Error validation of passed values. " + ex.Message);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Validates Triangle axises values.
        /// </summary>
        /// <returns>Returns validation result boolean value.</returns>
        public string ValidateTriangleValues()
        {
            var retVal = _parseNumberValidation.TryParseToNumber(TriangleEntity);
            if (!string.IsNullOrEmpty(retVal)) return retVal;
            retVal = _numValidation.GreaterThanZero(TriangleEntity);
            if (!string.IsNullOrEmpty(retVal)) return retVal;
            retVal = _triangleAxisesValidation.AxisesValidForTriangle(TriangleEntity);
            return retVal;
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets Triangle type.
        /// </summary>
        /// <returns></returns>
        public TriangleType GetTriangleType()
        {
            return TriangleEntity.FindTriangle();
        }

        /// <inheritdoc />
        /// <summary>
        /// Triangle entity property.
        /// </summary>
        public TriangleEntity TriangleEntity { get; set; }
    }
}