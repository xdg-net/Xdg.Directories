namespace Xdg.Directories;

/// <include file='docs/Other.xml' path='docs/Other/*'/>
public static class Other
{
    /// <include file='docs/Other.xml' path='docs/Home/*'/>
    public static string Home
    {
        get
        {
            string? homeEnv = Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => GetEnvironmentVariable("USERPROFILE"),
                Helpers.OS.MacOS => GetEnvironmentVariable("HOME"),
                Helpers.OS.UnixLike => GetEnvironmentVariable("HOME"),
                _ => null
            };
            return homeEnv ?? GetFolderPath(SpecialFolder.UserProfile);
        }
    }

    /// <include file='docs/Other.xml' path='docs/Applications/*'/>
    public static IList<string> Applications
    {
        get =>
            Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    =>
                    [
                        GetFolderPath(SpecialFolder.Programs),
                        GetFolderPath(SpecialFolder.CommonPrograms)
                    ],
                Helpers.OS.MacOS => ["/Applications"],
                Helpers.OS.UnixLike
                    =>
                    [
                        $"{BaseDirectory.DataHome}/applications",
                        $"{Home}/.local/share/applications",
                        "/usr/local/share/applications",
                        "/usr/share/applications",
                        // TODO: Add $XDG_DATA_DIRS/applications
                    ],
                _ => Array.Empty<string>()
            };
    }

    /// <include file='docs/Other.xml' path='docs/Fonts/*'/>
    public static IList<string> Fonts
    {
        get =>
            Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows
                    =>
                    [
                        GetEnvironmentVariable("SystemRoot") is string systemRoot
                            ? $"{systemRoot}\\Fonts"
                            : GetFolderPath(SpecialFolder.Fonts),
                        GetEnvironmentVariable("LOCALAPPDATA") is string localAppData
                            ? $"{localAppData}\\Microsoft\\Windows\\Fonts"
                            : $"{GetFolderPath(SpecialFolder.LocalApplicationData)}\\Microsoft\\Windows\\Fonts"
                    ],
                Helpers.OS.MacOS
                    =>
                    [
                        $"{Home}/Library/Fonts",
                        "/Library/Fonts",
                        "/System/Library/Fonts",
                        "/Network/Library/Fonts"
                    ],
                Helpers.OS.UnixLike
                    =>
                    [
                        Path.Combine(BaseDirectory.DataHome, "fonts"),
                        Path.Combine(Home, ".fonts"),
                        Path.Combine(Home, ".local", "share", "fonts"),
                        "/usr/local/share/fonts",
                        "/usr/share/fonts",
                        // TODO: Add $XDG_DATA_DIRS/fonts
                    ],
                _ => Array.Empty<string>()
            };
    }
}
