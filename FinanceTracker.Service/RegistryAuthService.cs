using FinanceTracker.Service.Interface;
using Microsoft.Win32;

namespace FinanceTracker.Service;

public class RegistryAuthService : IAuthService
{
    private const string REGISTRY_PATH = "FinanceTracker";
    private const string USER_ID = "UserId";

    public bool IsLogin()
    {
        using RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH);
        return key != null;
    }

    public int GetLastLogin()
    {
        using RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_PATH);
        string storedUserId = key.GetValue(USER_ID).ToString();
        bool tryParseUserId = int.TryParse(storedUserId, out int userId);

        return userId;
    }

    public void SaveLogin(int userId)
    {
        using RegistryKey key = Registry.CurrentUser.CreateSubKey(REGISTRY_PATH);
        key.SetValue(USER_ID, userId);
    }
}
