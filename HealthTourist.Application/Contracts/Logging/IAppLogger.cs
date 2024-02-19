namespace HealthTourist.Application.Contracts.Logging;

public interface IAppLogger<TEntity>
{
    void LogInformation(string message, params object[] args);
    void LogWarning(string message, params object[] args);
    void LogError(string message, params object[] args);
}