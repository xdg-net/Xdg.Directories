namespace Xdg.Directories;

/// <include file='docs/UserDirectory.xml' path='docs/UserDirectory'/>
public static class UserDirectory
{
    /// <include file='docs/UserDirectory.xml' path='docs/DesktopDir'/>
    public static string DesktopDir
    {
        get =>
            Helpers.OS(
                "XDG_DESKTOP_DIR",
                GetFolderPath(SpecialFolder.Desktop),
                $"{Other.Home}/Desktop",
                $"{Other.Home}/Desktop"
            )!;
    }

    /// <include file='docs/UserDirectory.xml' path='docs/DownloadDir'/>
    public static string? DownloadDir
    {
        get =>
            Helpers.OS(
                "XDG_DOWNLOAD_DIR",
                null, // TODO: Actually Implement?
                $"{Other.Home}/Downloads",
                $"{Other.Home}/Downloads"
            )!;
    }

    /// <include file='docs/UserDirectory.xml' path='docs/DocumentsDir'/>
    public static string DocumentsDir
    {
        get =>
            Helpers.OS(
                "XDG_DOCUMENTS_DIR",
                GetFolderPath(SpecialFolder.MyDocuments),
                $"{Other.Home}/Documents",
                $"{Other.Home}/Documents"
            )!;
    }

    /// <include file='docs/UserDirectory.xml' path='docs/MusicDir'/>
    public static string MusicDir
    {
        get =>
            Helpers.OS(
                "XDG_MUSIC_DIR",
                GetFolderPath(SpecialFolder.MyMusic),
                $"{Other.Home}/Music",
                $"{Other.Home}/Music"
            )!;
    }

    /// <include file='docs/UserDirectory.xml' path='docs/PicturesDir'/>
    public static string PicturesDir
    {
        get =>
            Helpers.OS(
                "XDG_PICTURES_DIR",
                GetFolderPath(SpecialFolder.MyPictures),
                $"{Other.Home}/Pictures",
                $"{Other.Home}/Pictures"
            )!;
    }

    /// <include file='docs/UserDirectory.xml' path='docs/VideosDir'/>
    public static string VideosDir
    {
        get =>
            Helpers.OS(
                "XDG_VIDEOS_DIR",
                GetFolderPath(SpecialFolder.MyVideos),
                $"{Other.Home}/Movies",
                $"{Other.Home}/Videos"
            )!;
    }

    /// <include file='docs/UserDirectory.xml' path='docs/TemplatesDir'/>
    public static string TemplatesDir
    {
        get =>
            Helpers.OS(
                "XDG_TEMPLATES_DIR",
                GetFolderPath(SpecialFolder.Templates),
                $"{Other.Home}/Templates",
                $"{Other.Home}/Templates"
            )!;
    }

    /// <include file='docs/UserDirectory.xml' path='docs/PublicDir'/>
    public static string PublicDir
    {
        get =>
            Helpers.OS(
                "XDG_PUBLICSHARE_DIR",
                GetEnvironmentVariable("PUBLIC"),
                $"{Other.Home}/Public",
                $"{Other.Home}/Public"
            )!;
    }
}
