using Penguin.DependencyInjection.Abstractions.Enums;
using System;

namespace Penguin.DependencyInjection.Abstractions.Attributes
{
    /// <summary>
    /// The base class for attributes that the DI should look for
    /// </summary>
    public abstract class DependencyRegistrationAttribute : Attribute
    {
        /// <summary>
        /// The lifetime of the object returned
        /// </summary>
        public ServiceLifetime Lifetime { get; set; }

        /// <summary>
        /// Constructs a new instance using the provided lifetime definition
        /// </summary>
        /// <param name="lifetime">The lifetime of the instantiated dependency</param>
        public DependencyRegistrationAttribute(ServiceLifetime lifetime)
        {
            this.Lifetime = lifetime;
        }
    }
}