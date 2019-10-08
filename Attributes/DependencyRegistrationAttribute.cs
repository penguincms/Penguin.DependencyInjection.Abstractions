using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.DependencyInjection.Abstractions.Attributes
{
    public abstract class DependencyRegistrationAttribute : Attribute
    {
        /// <summary>
        /// The lifetime of the object returned
        /// </summary>
        public ServiceLifetime Lifetime { get; set; }
        public DependencyRegistrationAttribute(ServiceLifetime lifetime)
        {
            Lifetime = lifetime;
        }
    }
}
