using System;
using TriangleTypeLibrary.Core.Interfaces.Factory;
using TriangleTypeLibrary.Core.Interfaces.Repository;
using TriangleTypeLibrary.Cross.Helpers.Validation.Implementation;
using Unity;
using Unity.Exceptions;
using Unity.Injection;

namespace TriangleTypeLibrary.Core.Implementation.Factory
{
    /// <inheritdoc />
    /// <summary>
    /// Triangle Factory class to get ITriangle implementer instance.
    /// </summary>
    /// <typeparam name="T">Implementer generic type.</typeparam>
    public class TriangleFactory<T> : ITriangleFactory<T> where T : ITriangleRepository
    {
        private static IUnityContainer _container;

        /// <inheritdoc />
        /// <summary>
        /// Instantiates implementer object.
        /// </summary>
        /// <returns>Returns implementer object.</returns>
        public T GetInstance()
        {
            ITriangleRepository unityContainer = null;
            try
            {
                if (_container != null) return (T) _container.Resolve<ITriangleRepository>();

                _container = new UnityContainer();
                _container.RegisterType<ITriangleRepository, T>(new InjectionConstructor(
                    new NumbericValidation(),
                    new TriangleAxisesValidation())
                );
                unityContainer = _container.Resolve<ITriangleRepository>();
                return (T) unityContainer;
            }
            catch (ResolutionFailedException)
            {
                return default(T);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}