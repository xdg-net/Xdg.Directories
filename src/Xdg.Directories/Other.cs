namespace Xdg.Directories;

/// <include file='docs/Other.xml' path='docs/Other/*'/>
public static class Other
{
    /// <include file='docs/Other.xml' path='docs/Home/*'/>
    public static string Home
    {
        get =>
            GetCurrentOperatingSystem() switch
            {
                OS.Windows => GetEnvironmentVariable("USERPROFILE"),
                OS.MacOS => GetEnvironmentVariable("HOME"),
                OS.UnixLike => GetEnvironmentVariable("HOME"),
                _ => null
            }
            ?? GetFolderPath(SpecialFolder.UserProfile);
    }

    /// <include file='docs/Other.xml' path='docs/Applications/*'/>
    public static IList<string> Applications
    {
        get =>
            GetCurrentOperatingSystem() switch
            {
                OS.Windows
                    =>
                    [
                        GetFolderPath(SpecialFolder.Programs),
                        GetFolderPath(SpecialFolder.CommonPrograms)
                    ],
                OS.MacOS => ["/Applications"],
                OS.UnixLike
                    =>
                    [
                        $"{BaseDirectory.DataHome}/applications",
                        $"{Home}/.local/share/applications",
                        "/usr/local/share/applications",
                        "/usr/share/applications",
                        // TODO: Add $XDG_DATA_DIRS/applications
                    ],
                _ => []
            };
    }

    /// <include file='docs/Other.xml' path='docs/Fonts/*'/>
    public static IList<string> Fonts
    {
        get =>
            GetCurrentOperatingSystem() switch
            {
                OS.Windows
                    =>
                    [
                        GetEnvironmentVariable("SystemRoot") is not null
                            ? $"{GetEnvironmentVariable("SystemRoot")}\\Fonts"
                            : GetFolderPath(SpecialFolder.Fonts),
                        GetEnvironmentVariable("LOCALAPPDATA") is not null
                            ? $"{GetEnvironmentVariable("LOCALAPPDATA")}\\Microsoft\\Windows\\Fonts"
                            : $"{GetFolderPath(SpecialFolder.LocalApplicationData)}\\Microsoft\\Windows\\Fonts"
                    ],
                OS.MacOS
                    =>
                    [
                        $"{Home}/Library/Fonts",
                        "/Library/Fonts",
                        "/System/Library/Fonts",
                        "/Network/Library/Fonts"
                    ],
                OS.UnixLike
                    =>
                    [
                        Path.Combine(BaseDirectory.DataHome, "fonts"),
                        Path.Combine(Home, ".fonts"),
                        Path.Combine(Home, ".local", "share", "fonts"),
                        "/usr/local/share/fonts",
                        "/usr/share/fonts",
                        // TODO: Add $XDG_DATA_DIRS/fonts
                    ],
                _ => []
            };
    }
}
