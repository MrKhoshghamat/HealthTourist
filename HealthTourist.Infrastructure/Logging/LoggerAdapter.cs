using HealthTourist.Application.Contracts.Logging;
using Microsoft.Extensions.Logging;

namespace HealthTourist.Infrastructure.Logging;

public class LoggerAdapter<TEntity>(ILoggerFactory loggerFactory) : IAppLogger<TEntity>
{
    private readonly ILogger<TEntity> _logger = loggerFactory.CreateLogger<TEntity>();

    public void LogInformation(string message, params object[] args)
    {
        _logger.LogInformation(message, args);
    }

    public void LogWarning(string message, params object[] args)
    {
        _logger.LogWarning(message, args);
    }

    public void LogError(string message, params object[] args)
    {
        _logger.LogError(message, args);
    }
}