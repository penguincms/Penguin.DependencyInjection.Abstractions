using Penguin.DependencyInjection.Abstractions.Enums;
using System;

namespace Penguin.DependencyInjection.Abstractions.Attributes
{
    /// <summary>
    /// Allows attributing a class so that the DI automatically registers it to itself with the given Service Provider type
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisterAttribute : DependencyRegistrationAttribute
    {

        /// <summary>
        /// The types that should resolve to this class
        /// </summary>
        public Type[] RegisteredTypes { get; set; }

        /// <summary>
        /// Constructs a new instance of this attribute
        /// </summary>
        /// <param name="lifetime">The lifetime of the object returned</param>
        /// <param name="registeredTypes">The types that should resolve to this class</param>
        public RegisterAttribute(ServiceLifetime lifetime, params Type[] registeredTypes) : base(lifetime)
        {
            RegisteredTypes = registeredTypes;
        }
    }
}

