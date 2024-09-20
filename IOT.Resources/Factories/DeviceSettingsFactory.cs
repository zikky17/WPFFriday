using IOT.Resources.Models;

namespace IOT.Resources.Factories;

public class DeviceSettingsFactory
{
    public static DeviceSettings Create()
    {
        return new DeviceSettings()
        {
            Id = Guid.NewGuid().ToString()
        };
    }

    public static DeviceSettings Create(string id)
    {
        return new DeviceSettings()
        {
            Id = id,
        };
    }

    public static DeviceSettings Create(string id, string? location, string? type, string connectionString)
    {
        return new DeviceSettings()
        {
            Id = id,
            Location = location,
            Type = type,
            ConnectionString = connectionString
        };
    }
}
