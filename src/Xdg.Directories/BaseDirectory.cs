namespace Xdg.Directories;

/// <include file='docs/BaseDirectory.xml' path='docs/BaseDirectory'/>
public static class BaseDirectory
{
    /// <include file='docs/BaseDirectory.xml' path='docs/DataHome'/>
    public static string DataHome
    {
        get =>
            Helpers.OS(
                "XDG_DATA_HOME",
                GetEnvironmentVariable("LOCALAPPDATA")
                    ?? GetFolderPath(SpecialFolder.LocalApplicationData),
                $"{Other.Home}/Library/Application Support",
                $"{Other.Home}/.local/share"
            )!;
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/ConfigHome'/>
    public static string ConfigHome
    {
        get =>
            Helpers.OS(
                "XDG_CONFIG_HOME",
                GetEnvironmentVariable("LOCALAPPDATA")
                    ?? GetFolderPath(SpecialFolder.LocalApplicationData),
                $"{Other.Home}/Library/Application Support",
                $"{Other.Home}/.config"
            )!;
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/StateHome'/>
    public static string StateHome
    {
        get =>
            Helpers.OS(
                "XDG_STATE_HOME",
                GetEnvironmentVariable("LOCALAPPDATA")
                    ?? GetFolderPath(SpecialFolder.LocalApplicationData),
                $"{Other.Home}/Library/Application Support",
                $"{Other.Home}/.local/state"
            )!;
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/BinHome'/>
    public static string? BinHome
    {
        get => Helpers.OS("XDG_BIN_HOME", null, null, $"{Other.Home}/.local/bin")!;
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/DataDirs'/>
    public static IList<string> DataDirs
    {
        get =>
            Helpers.OS(
                "XDG_DATA_DIRS",
                new string[]
                {
                    Helpers.AorB(
                        GetFolderPath(SpecialFolder.ApplicationData),
                        GetEnvironmentVariable("APPDATA")!
                    ),
                    GetEnvironmentVariable("PROGRAMDATA")
                        ?? GetFolderPath(SpecialFolder.CommonApplicationData)
                },
                new string[] { "/Library/Application Support" },
                new string[] { "/usr/local/share", "/usr/share" }
            )!;
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/ConfigDirs'/>
    public static IList<string> ConfigDirs
    {
        get =>
            Helpers.OS(
                "XDG_CONFIG_DIRS",
                new string[]
                {
                    GetEnvironmentVariable("PROGRAMDATA")
                        ?? GetFolderPath(SpecialFolder.CommonApplicationData),
                    Helpers.AorB(
                        GetFolderPath(SpecialFolder.ApplicationData),
                        GetEnvironmentVariable("APPDATA")!
                    )
                },
                new string[]
                {
                    $"{Other.Home}/Library/Preferences",
                    "/Library/Application Support",
                    "/Library/Preferences"
                },
                new string[] { "/etc/xdg" }
            )!;
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/CacheHome'/>
    public static string CacheHome
    {
        get =>
            Helpers.OS(
                "XDG_CACHE_HOME",
                GetEnvironmentVariable("LOCALAPPDATA") is not null
                    ? $"{GetEnvironmentVariable("LOCALAPPDATA")}\\cache"
                    : $"{GetFolderPath(SpecialFolder.LocalApplicationData)}\\cache",
                $"{Other.Home}/Library/Caches",
                $"{Other.Home}/.cache"
            )!;
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/RuntimeDir'/>
    public static string RuntimeDir
    {
        get =>
            Helpers.OS(
                "XDG_RUNTIME_DIR",
                GetEnvironmentVariable("LOCALAPPDATA")
                    ?? GetFolderPath(SpecialFolder.LocalApplicationData),
                $"{Other.Home}/Library/Application Support",
                $"/run/user/{GetEnvironmentVariable("UID")}"
            )!;
    }
}
