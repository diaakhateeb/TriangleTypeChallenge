namespace TriangleTypeLibrary.Core.Interfaces.Factory
{
    /// <summary>
    /// Triangle Factory interface.
    /// </summary>
    /// <typeparam name="T">Generic type of which factory will return object.</typeparam>
    public interface ITriangleFactory<out T>
    {
        /// <summary>
        ///     Instantiates implementer object.
        /// </summary>
        /// <returns>Returns implementer object.</returns>
        T GetInstance();
    }
}