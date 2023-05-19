#if NET7_0_OR_GREATER
#pragma warning disable CA1031 // General exceptions needed for handling errors
using System.Runtime.InteropServices;

namespace Xdg.Directories.FFI;

/// <summary>
/// Native library export wrappers
/// </summary>
internal static partial class Exports
{
    [UnmanagedCallersOnly(EntryPoint = "xdg_data_home")]
    public static IntPtr DataHome()
    {
        try
        {
            return StringToPtr(BaseDirectory.DataHome);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_config_home")]
    public static IntPtr ConfigHome()
    {
        try
        {
            return StringToPtr(BaseDirectory.ConfigHome);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_state_home")]
    public static IntPtr StateHome()
    {
        try
        {
            return StringToPtr(BaseDirectory.StateHome);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_bin_home")]
    public static IntPtr BinHome()
    {
        try
        {
            return StringToPtr(BaseDirectory.BinHome);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_cache_home")]
    public static IntPtr CacheHome()
    {
        try
        {
            return StringToPtr(BaseDirectory.CacheHome);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }

    [UnmanagedCallersOnly(EntryPoint = "xdg_runtime_dir")]
    public static IntPtr RuntimeDir()
    {
        try
        {
            return StringToPtr(BaseDirectory.RuntimeDir);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }
}
#endif