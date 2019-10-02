using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.DependencyInjection.Abstractions.Attributes
{
    /// <summary>
    /// Allows attributing a class so that the DI automatically registers it to itself with the given Service Provider type
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceProviderAttribute : Attribute
    {
        /// <summary>
        /// The type of the service provider that should be used to resolve this class
        /// </summary>
        public Type ServiceProvider { get; set; }

        /// <summary>
        /// The types that should resolve to this class
        /// </summary>
        public Type[] RegisteredTypes { get; set; }

        /// <summary>
        /// Constructs a new instance of this attribute
        /// </summary>
        /// <param name="serviceProvider">The type of the service provider that should be used to resolve this class</param>
        /// <param name="registeredTypes">The types that should resolve to this class</param>
        public ServiceProviderAttribute(Type serviceProvider, params Type[] registeredTypes)
        {
            ServiceProvider = serviceProvider;
            RegisteredTypes = registeredTypes;
        }
    }
}

