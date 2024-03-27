namespace Xdg.Directories;

/// <include file='docs/BaseDirectory.xml' path='docs/BaseDirectory/*'/>
public static class BaseDirectory
{
    /// <include file='docs/BaseDirectory.xml' path='docs/DataHome/*'/>
    public static string DataHome
    {
        get =>
            GetEnvironmentVariable("XDG_DATA_HOME")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    => GetEnvironmentVariable("LOCALAPPDATA")
                        ?? GetFolderPath(SpecialFolder.LocalApplicationData),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Library", "Application Support"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, ".local", "share"),
                _ => string.Empty
            };
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/ConfigHome/*'/>
    public static string ConfigHome
    {
        get =>
            GetEnvironmentVariable("XDG_CONFIG_HOME")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    => GetEnvironmentVariable("LOCALAPPDATA")
                        ?? GetFolderPath(SpecialFolder.LocalApplicationData),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Library", "Application Support"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, ".config"),
                _ => string.Empty
            };
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/StateHome/*'/>
    public static string StateHome
    {
        get =>
            GetEnvironmentVariable("XDG_STATE_HOME")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    => GetEnvironmentVariable("LOCALAPPDATA")
                        ?? GetFolderPath(SpecialFolder.LocalApplicationData),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Library", "Application Support"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, ".local", "state"),
                _ => string.Empty
            };
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/BinHome/*'/>
    public static string BinHome
    {
        get =>
            GetEnvironmentVariable("XDG_BIN_HOME")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => string.Empty,
                Helpers.OS.MacOS => string.Empty,
                Helpers.OS.UnixLike => Path.Combine(Other.Home, ".local", "bin"),
                _ => string.Empty
            };
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/DataDirs/*'/>
    public static IList<string> DataDirs
    {
        get =>
            GetEnvironmentVariable("XDG_DATA_DIRS")?.Split(':')
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    =>
                    [
                        GetEnvironmentVariable("APPDATA")
                            ?? GetFolderPath(SpecialFolder.ApplicationData),
                        GetEnvironmentVariable("PROGRAMDATA")
                            ?? GetFolderPath(SpecialFolder.CommonApplicationData)
                    ],
                Helpers.OS.MacOS => ["/Library/Application Support"],
                Helpers.OS.UnixLike => ["/usr/local/share", "/usr/share"],
                _ => []
            };
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/ConfigDirs/*'/>
    public static IList<string> ConfigDirs
    {
        get =>
            GetEnvironmentVariable("XDG_CONFIG_DIRS")?.Split(':')
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    =>
                    [
                        GetEnvironmentVariable("ProgramData")
                            ?? GetFolderPath(SpecialFolder.CommonApplicationData),
                        GetEnvironmentVariable("APPDATA")
                            ?? GetFolderPath(SpecialFolder.ApplicationData)
                    ],
                Helpers.OS.MacOS
                    =>
                    [
                        Path.Combine(Other.Home, "Library", "Preferences"),
                        "/Library/Application Support",
                        "/Library/Preferences"
                    ],
                Helpers.OS.UnixLike => ["/etc/xdg"],
                _ => []
            };
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/CacheHome/*'/>
    public static string CacheHome
    {
        get =>
            GetEnvironmentVariable("XDG_CACHE_HOME")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    => GetEnvironmentVariable("LOCALAPPDATA") is not null
                        ? Path.Combine(GetEnvironmentVariable("LOCALAPPDATA")!, "cache")
                        : Path.Combine(GetFolderPath(SpecialFolder.LocalApplicationData), "cache"),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Library", "Caches"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, ".cache"),
                _ => string.Empty
            };
    }

    /// <include file='docs/BaseDirectory.xml' path='docs/RuntimeDir/*'/>
    public static string RuntimeDir
    {
        get =>
            GetEnvironmentVariable("XDG_RUNTIME_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    => GetEnvironmentVariable("LOCALAPPDATA")
                        ?? GetFolderPath(SpecialFolder.LocalApplicationData),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Library", "Application Support"),
                Helpers.OS.UnixLike => Path.Combine("/run", "user", GetEnvironmentVariable("UID") ?? "0"),
                _ => string.Empty
            };
    }
}
