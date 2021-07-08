namespace Penguin.DependencyInjection.Abstractions.Interfaces
{
    /// <summary>
    /// When implemented, the Penguin DI system will return a transient instance of the most derived class that inherits from this one, if the class is not registered when requested
    /// This is useful for ensuring that consuming library implementations of a class are always selected over the class that defines this
    /// </summary>
    public interface IRegisterMostDerived : ISelfRegistering
    {
    }
}