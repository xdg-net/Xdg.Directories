namespace Xdg.Directories;

/// <include file='docs/UserDirectory.xml' path='docs/UserDirectory/*'/>
public static class UserDirectory
{
    /// <include file='docs/UserDirectory.xml' path='docs/DesktopDir/*'/>
    public static string DesktopDir
    {
        get =>
            GetEnvironmentVariable("XDG_DESKTOP_DIR")
            ?? GetCurrentOperatingSystem() switch
            {
                OS.Windows => GetFolderPath(SpecialFolder.Desktop),
                OS.MacOS => Path.Combine(Other.Home, "Desktop"),
                OS.UnixLike => Path.Combine(Other.Home, "Desktop"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/DownloadDir/*'/>
    public static string DownloadDir
    {
        get =>
            GetEnvironmentVariable("XDG_DOWNLOAD_DIR")
            ?? GetCurrentOperatingSystem() switch
            {
                // TODO: Implement this ourselves because Microsoft doesn't.
                OS.Windows => string.Empty,
                OS.MacOS => Path.Combine(Other.Home, "Downloads"),
                OS.UnixLike => Path.Combine(Other.Home, "Downloads"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/DocumentsDir/*'/>
    public static string DocumentsDir
    {
        get =>
            GetEnvironmentVariable("XDG_DOCUMENTS_DIR")
            ?? GetCurrentOperatingSystem() switch
            {
                OS.Windows => GetFolderPath(SpecialFolder.MyDocuments),
                OS.MacOS => Path.Combine(Other.Home, "Documents"),
                OS.UnixLike => Path.Combine(Other.Home, "Documents"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/MusicDir/*'/>
    public static string MusicDir
    {
        get =>
            GetEnvironmentVariable("XDG_MUSIC_DIR")
            ?? GetCurrentOperatingSystem() switch
            {
                OS.Windows => GetFolderPath(SpecialFolder.MyMusic),
                OS.MacOS => Path.Combine(Other.Home, "Music"),
                OS.UnixLike => Path.Combine(Other.Home, "Music"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/PicturesDir/*'/>
    public static string PicturesDir
    {
        get =>
            GetEnvironmentVariable("XDG_PICTURES_DIR")
            ?? GetCurrentOperatingSystem() switch
            {
                OS.Windows => GetFolderPath(SpecialFolder.MyPictures),
                OS.MacOS => Path.Combine(Other.Home, "Pictures"),
                OS.UnixLike => Path.Combine(Other.Home, "Pictures"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/VideosDir/*'/>
    public static string VideosDir
    {
        get =>
            GetEnvironmentVariable("XDG_VIDEOS_DIR")
            ?? GetCurrentOperatingSystem() switch
            {
                OS.Windows => GetFolderPath(SpecialFolder.MyVideos),
                OS.MacOS => Path.Combine(Other.Home, "Movies"),
                OS.UnixLike => Path.Combine(Other.Home, "Videos"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/TemplatesDir/*'/>
    public static string TemplatesDir
    {
        get =>
            GetEnvironmentVariable("XDG_TEMPLATES_DIR")
            ?? GetCurrentOperatingSystem() switch
            {
                OS.Windows => GetFolderPath(SpecialFolder.Templates),
                OS.MacOS => Path.Combine(Other.Home, "Templates"),
                OS.UnixLike => Path.Combine(Other.Home, "Templates"),
                _ => string.Empty
            };
    }

    /// <include file='docs/UserDirectory.xml' path='docs/PublicDir/*'/>
    public static string PublicDir
    {
        get =>
            GetEnvironmentVariable("XDG_PUBLICSHARE_DIR")
            ?? GetCurrentOperatingSystem() switch
            {
                OS.Windows => GetEnvironmentVariable("PUBLIC") ?? string.Empty,
                OS.MacOS => Path.Combine(Other.Home, "Public"),
                OS.UnixLike => $"{Other.Home}/Public",
                _ => string.Empty
            };
    }
}
