using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.DependencyInjection.Abstractions.Interfaces
{
    /// <summary>
    /// Marks a class as being capable of squashing multiple registered instances into a single instance of the registered type, intended for ListProviders that have their own internal logic about prioritizing dependency usage
    /// </summary>
    /// <typeparam name="TDependency">The type of provider that this class consolidates</typeparam>
    public interface IConsolidateDependencies<TDependency>
    {

        /// <summary>
        /// Squash the list down
        /// </summary>
        TDependency Consolidate(IEnumerable<TDependency> dependencies);


    }
}
