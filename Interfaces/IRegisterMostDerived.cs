namespace Penguin.DependencyInjection.Abstractions.Interfaces
{
    /// <summary>
    /// When implemented, the Penguin DI system will return a transient instance of the most derived class that inherits from this one, if the class is not registered when requested
    /// This is useful for ensuring that consuming library implementations of a class are always selected over the class that defines this
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1040:Avoid empty interfaces", Justification = "<Pending>")]
    public interface IRegisterMostDerived : ISelfRegistering
    {
    }
}