using Microsoft.Extensions.DependencyInjection;
using System;

namespace Penguin.DependencyInjection.Abstractions.Interfaces
{
    /// <summary>
    /// Denotes that this class should be used by the Penguin DI Engine to register dependencies on initialization
    /// </summary>
    public interface IRegisterDependencies
    {
        /// <summary>
        /// A method that actually calls the static instance of the Penguin DI engine to register the instances
        /// </summary>
        void RegisterDependencies(Action<Type, Type, ServiceLifetime> registrationFunc);
    }
}