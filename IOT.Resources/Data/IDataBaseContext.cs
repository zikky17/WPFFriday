using IOT.Resources.Models;

namespace IOT.Resources.Data;

public interface IDataBaseContext
{
    Task<ResultResponse<DeviceSettings>> GetSettingsAsync();

    Task<ResultResponse> ResetSettingsAsync();

    Task<ResultResponse> SaveSettingsAsync(DeviceSettings settings);

}
