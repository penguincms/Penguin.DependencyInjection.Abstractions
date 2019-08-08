namespace Penguin.DependencyInjection.Abstractions
{
    /// <summary>
    /// When implemented, the Penguin DI system will create a transient instance of the object if it is unregistered when it is requested
    /// </summary>
    public interface ISelfRegistering
    {
    }
}