namespace Xdg.Directories;

/// <include file='docs/Other.xml' path='docs/Other'/>
public static class Other
{
    /// <include file='docs/Other.xml' path='docs/Home'/>
    public static string Home
    {
        get
        {
            // Unix ?? Windows
            string? home =
                GetEnvironmentVariable("HOME")
                ?? GetEnvironmentVariable("USERPROFILE");
            if (home is not null)
                return home;
            else
                return GetFolderPath(SpecialFolder.UserProfile);
        }
    }

    /// <include file='docs/Other.xml' path='docs/Applications'/>
    public static IList<string> Applications
    {
        get =>
            Helpers.OS(
                "",
                new string[]
                {
                    GetFolderPath(SpecialFolder.Programs),
                    GetFolderPath(SpecialFolder.CommonPrograms)
                },
                new string[] { "/Applications" },
                new string[]
                {
                    $"{BaseDirectory.DataHome}/applications",
                    $"{Home}/.local/share/applications",
                    "/usr/local/share/applications",
                    "/usr/share/applications",
                    // TODO: Add $XDG_DATA_DIRS/applications
                }
            )!;
    }

    /// <include file='docs/Other.xml' path='docs/Fonts'/>
    public static IList<string> Fonts
    {
        get =>
            Helpers.OS(
                "",
                new string[]
                {
                    GetEnvironmentVariable("SystemRoot") is not null
                        ? $"{GetEnvironmentVariable("SystemRoot")}\\Fonts"
                        : GetFolderPath(SpecialFolder.Fonts),
                    GetEnvironmentVariable("LOCALAPPDATA") is not null
                        ? $"{GetEnvironmentVariable("LOCALAPPDATA")}\\Microsoft\\Windows\\Fonts"
                        : $"{GetFolderPath(SpecialFolder.LocalApplicationData)}\\Microsoft\\Windows\\Fonts"
                },
                new string[]
                {
                    $"{Home}/Library/Fonts",
                    "/Library/Fonts",
                    "/System/Library/Fonts",
                    "/Network/Library/Fonts"
                },
                new string[]
                {
                    $"{BaseDirectory.DataHome}/fonts",
                    $"{Home}/.fonts",
                    $"{Home}/.local/share/fonts",
                    "/usr/local/share/fonts",
                    "/usr/share/fonts",
                    // TODO: Add $XDG_DATA_DIRS/fonts
                }
            )!;
    }
}
