namespace Penguin.DependencyInjection.Abstractions
{
    /// <summary>
    /// Denotes that this class should be used by the Penguin DI Engine to register dependencies on initialization
    /// </summary>
    public interface IRegisterDependencies
    {
        #region Methods

        /// <summary>
        /// A method that actually calls the static instance of the Penguin DI engine to register the instances
        /// </summary>
        void RegisterDependencies();

        #endregion Methods
    }
}