using IOT.Resources.Models;
using Microsoft.Extensions.Logging;
using SQLite;

namespace IOT.Resources.Data;

public class SqliteContext : IDataBaseContext
{
    private readonly ILogger<SqliteContext> _logger;
    private readonly SQLiteAsyncConnection? _context;

    public SqliteContext(ILogger<SqliteContext> logger, Func<string> directoryPath, string databaseName = "database.db3")
    {
        _logger = logger;

        try
        {
            var databasePath = Path.Combine(directoryPath(), databaseName);
            if(string.IsNullOrWhiteSpace(databasePath))
                throw new ArgumentException("The database path cannot be null or empty.");

            _context = new SQLiteAsyncConnection(databasePath);
            CreateTablesAsync().ConfigureAwait(false);

        }
        catch(Exception ex)
        {
            _logger.LogError(ex, "An error occured while creating the database connection.");
        }
    }

    public async Task CreateTablesAsync()
    {
        try
        {
            if (_context == null)
            {
                throw new ArgumentException("The database has not been initialized.");
               
            }
            else
            {
                await _context.CreateTableAsync<DeviceSettings>();

                _logger.LogInformation("Database tables were created successfully.");
            }

        }
        catch(Exception ex)
        {
            _logger.LogError(ex, "An error occured while creating the database tables.");
        }
    }

    public async Task<ResultResponse<DeviceSettings>> GetSettingsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResultResponse> ResetSettingsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResultResponse> SaveSettingsAsync(DeviceSettings settings)
    {
        throw new NotImplementedException();
    }
}
