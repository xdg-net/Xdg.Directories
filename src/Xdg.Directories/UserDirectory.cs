namespace Xdg.Directories;

/// <include file='docs/UserDirectory.xml' path='docs/UserDirectory'/>
public static class UserDirectory
{
    /// <include file='docs/UserDirectory.xml' path='docs/DesktopDir'/>
    public static string DesktopDir
    {
        get =>
            GetEnvironmentVariable("XDG_DESKTOP_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => GetFolderPath(SpecialFolder.Desktop),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Desktop"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, "Desktop"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/DownloadDir'/>
    public static string DownloadDir
    {
        get =>
            GetEnvironmentVariable("XDG_DOWNLOAD_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                // TODO: Implement this ourselves because Microsoft doesn't.
                Helpers.OS.Windows => string.Empty,
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Downloads"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, "Downloads"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/DocumentsDir'/>
    public static string DocumentsDir
    {
        get =>
            GetEnvironmentVariable("XDG_DOCUMENTS_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => GetFolderPath(SpecialFolder.MyDocuments),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Documents"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, "Documents"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/MusicDir'/>
    public static string MusicDir
    {
        get =>
            GetEnvironmentVariable("XDG_MUSIC_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => GetFolderPath(SpecialFolder.MyMusic),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Music"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, "Music"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/PicturesDir'/>
    public static string PicturesDir
    {
        get =>
            GetEnvironmentVariable("XDG_PICTURES_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => GetFolderPath(SpecialFolder.MyPictures),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Pictures"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, "Pictures"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/VideosDir'/>
    public static string VideosDir
    {
        get =>
            GetEnvironmentVariable("XDG_VIDEOS_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => GetFolderPath(SpecialFolder.MyVideos),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Movies"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, "Videos"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/TemplatesDir'/>
    public static string TemplatesDir
    {
        get =>
            GetEnvironmentVariable("XDG_TEMPLATES_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => GetFolderPath(SpecialFolder.Templates),
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Templates"),
                Helpers.OS.UnixLike => Path.Combine(Other.Home, "Templates"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/PublicDir'/>
    public static string PublicDir
    {
        get =>
            GetEnvironmentVariable("XDG_PUBLICSHARE_DIR")
            ?? Helpers.GetCurrentOperatingSystem() switch
            {
                Helpers.OS.Windows => GetEnvironmentVariable("PUBLIC") ?? string.Empty,
                Helpers.OS.MacOS => Path.Combine(Other.Home, "Public"),
                Helpers.OS.UnixLike => $"{Other.Home}/Public",
                _ => string.Empty
            };
    }
}
