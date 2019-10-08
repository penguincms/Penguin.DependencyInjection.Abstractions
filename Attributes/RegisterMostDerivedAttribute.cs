using Penguin.DependencyInjection.Abstractions.Enums;
using System;

namespace Penguin.DependencyInjection.Abstractions.Attributes
{
    /// <summary>
    /// Registers the most derived type from this class, over and through the provided type, using the given service provider
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisterThroughMostDerivedAttribute : DependencyRegistrationAttribute
    {
        /// <summary>
        /// The type that will be requested by the service provider
        /// </summary>
        public Type RequestType { get; set; }

        /// <summary>
        /// Constructs a new instance of this attribute
        /// </summary>
        /// <param name="requestType">The type that will be requested by the service provider</param>
        /// <param name="lifetime">The lifetime of the object returned</param>
        public RegisterThroughMostDerivedAttribute(Type requestType, ServiceLifetime lifetime) : base(lifetime)
        {
            RequestType = requestType;

        }
    }
}
