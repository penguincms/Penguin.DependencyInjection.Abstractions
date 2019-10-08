using Penguin.DependencyInjection.Abstractions.Enums;
using System;

namespace Penguin.DependencyInjection.Abstractions.Interfaces
{
    /// <summary>
    /// Defines a class capable of registering services to a dependency injector in the most basic form
    /// </summary>
    public interface IServiceRegister
    {
        /// <summary>
        /// Registers TRegistration to return type TImplementation using the defined lifetime
        /// </summary>
        /// <typeparam name="TRegistration">The type that will be requested</typeparam>
        /// <typeparam name="TImplementation">The type that will be returned</typeparam>
        /// <param name="serviceLifetime">The lifetime of the instance returned</param>
        void Register<TRegistration, TImplementation>(ServiceLifetime serviceLifetime) where TImplementation : TRegistration;

        /// <summary>
        /// Registers TRegistration to return type TImplementation using the defined lifetime
        /// </summary>
        /// <param name="TRegistration">The type that will be requested</param>
        /// <param name="TImplementation">The type that will be returned</param>
        /// <param name="serviceLifetime">The lifetime of the instance returned</param>
        void Register(Type TRegistration, Type TImplementation, ServiceLifetime serviceLifetime);

        /// <summary>
        /// Registers TRegistration to TImplementation, and uses the provided Func to generate the result
        /// </summary>
        /// <typeparam name="TRegistration">The type that will be requested</typeparam>
        /// <typeparam name="TImplementation">The type that will be returned</typeparam>
        /// <param name="RetrieveInstance">The function that generates the result</param>
        /// <param name="serviceLifetime">The lifetime of the instance returned</param>
        void Register<TRegistration>(Func<IServiceProvider, TRegistration> RetrieveInstance, ServiceLifetime serviceLifetime);

        /// <summary>
        /// Registers TRegistration to call the provided func to get its return value
        /// </summary>
        /// <param name="TRegistration">The type that will be requested</param>
        /// <param name="RetrieveInstance">The function that generates the result</param>
        /// <param name="serviceLifetime">The lifetime of the instance returned</param>
        void Register(Type TRegistration, Func<IServiceProvider, object> RetrieveInstance, ServiceLifetime serviceLifetime);
    }
}
