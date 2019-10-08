using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.DependencyInjection.Abstractions.Interfaces
{
    /// <summary>
    /// Marks a class as being capable of squashing multiple registered instances into a single instance of the registered type, intended for ListProviders that have their own internal logic about prioritizing dependency usage
    /// </summary>
    /// <typeparam name="TDependency">The type of provider that this class consolidates</typeparam>
    /// <typeparam name="TInstantiation">The type of provider that this class consolidates</typeparam>
    public interface IConsolidateDependencies<TDependency, TInstantiation> where TInstantiation : TDependency
    {
        /// <summary>
        /// Construct a new instance of the consolidating class. This is called before the children are 
        /// instantiated in the event that one of the childred indirectly requires a TDependency, so that an instance 
        /// can exist before resolution is called so that we dont have a 
        /// </summary>
        /// <returns></returns>
        TInstantiation Construct();

        /// <summary>
        /// Squashes a list of registered instances down to a single consolidated instance
        /// </summary>
        /// <param name="instantiation">The previously constructed instance of this consolidator, ready to be filled</param>
        /// <param name="Instances">The IEnumerable of existing instances returned by the DI</param>
        /// <returns>A single squashed instance that uses all of the existing DI instances</returns>
        void Populate(TInstantiation instantiation, IEnumerable<TDependency> Instances);
    }
}
