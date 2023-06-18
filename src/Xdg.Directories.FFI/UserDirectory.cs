#if NET7_0_OR_GREATER
#pragma warning disable CA1031 // General exceptions needed for handling errors
using System.Runtime.InteropServices;

namespace Xdg.Directories.FFI;
internal static partial class Exports
{
    [UnmanagedCallersOnly(EntryPoint = "xdg_desktop_dir")]
    public static IntPtr Desktop()
    {
        try
        {
            return StringToPtr(UserDirectory.DesktopDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_download_dir")]
    public static IntPtr Download()
    {
        try
        {
            return StringToPtr(UserDirectory.DownloadDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_documents_dir")]
    public static IntPtr Documents()
    {
        try
        {
            return StringToPtr(UserDirectory.DocumentsDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_music_dir")]
    public static IntPtr Music()
    {
        try
        {
            return StringToPtr(UserDirectory.MusicDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_pictures_dir")]
    public static IntPtr Pictures()
    {
        try
        {
            return StringToPtr(UserDirectory.PicturesDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_videos_dir")]
    public static IntPtr Videos()
    {
        try
        {
            return StringToPtr(UserDirectory.VideosDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_templates_dir")]
    public static IntPtr Templates()
    {
        try
        {
            return StringToPtr(UserDirectory.TemplatesDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_publicshare_dir")]
    public static IntPtr Public()
    {
        try
        {
            return StringToPtr(UserDirectory.PublicDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }
}
#endif