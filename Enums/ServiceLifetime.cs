using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.DependencyInjection.Abstractions.Enums
{
    /// <summary>
    /// Specifies the lifetime of a service in an Microsoft.Extensions.DependencyInjection.IServiceCollection.
    /// </summary>

    public enum ServiceLifetime
    {

        /// <summary>
        /// Specifies that a single instance of the service will be created.
        /// </summary>
        Singleton = 0,

        /// <summary>
        /// Specifies that a new instance of the service will be created for each scope.
        /// </summary>
        Scoped = 1,

        /// <summary>
        /// Specifies that a new instance of the service will be created every time it is
        /// </summary>
        Transient = 2
    }
}
