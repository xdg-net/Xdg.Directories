#if NET7_0_OR_GREATER
using System.Runtime.InteropServices;

namespace Xdg.Directories.FFI;

internal static partial class Exports
{
    [UnmanagedCallersOnly(EntryPoint = "xdg_desktop_dir")]
    public static IntPtr Desktop() => StringToPtr(UserDirectory.DesktopDir);

    [UnmanagedCallersOnly(EntryPoint = "xdg_download_dir")]
    public static IntPtr Download() => StringToPtr(UserDirectory.DownloadDir);

    [UnmanagedCallersOnly(EntryPoint = "xdg_documents_dir")]
    public static IntPtr Documents() => StringToPtr(UserDirectory.DocumentsDir);

    [UnmanagedCallersOnly(EntryPoint = "xdg_music_dir")]
    public static IntPtr Music() => StringToPtr(UserDirectory.MusicDir);

    [UnmanagedCallersOnly(EntryPoint = "xdg_pictures_dir")]
    public static IntPtr Pictures() => StringToPtr(UserDirectory.PicturesDir);

    [UnmanagedCallersOnly(EntryPoint = "xdg_videos_dir")]
    public static IntPtr Videos() => StringToPtr(UserDirectory.VideosDir);

    [UnmanagedCallersOnly(EntryPoint = "xdg_templates_dir")]
    public static IntPtr Templates() => StringToPtr(UserDirectory.TemplatesDir);

    [UnmanagedCallersOnly(EntryPoint = "xdg_publicshare_dir")]
    public static IntPtr Public() => StringToPtr(UserDirectory.PublicDir);
}
#endif
