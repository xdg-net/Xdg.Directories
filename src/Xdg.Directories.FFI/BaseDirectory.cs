#if NET7_0_OR_GREATER
using System.Runtime.InteropServices;

namespace Xdg.Directories.FFI;

/// <summary>
/// Native library export wrappers
/// </summary>
internal static partial class Exports
{
    [UnmanagedCallersOnly(EntryPoint = "xdg_data_home")]
    public static IntPtr DataHome() => StringToPtr(BaseDirectory.DataHome);

    [UnmanagedCallersOnly(EntryPoint = "xdg_config_home")]
    public static IntPtr ConfigHome() => StringToPtr(BaseDirectory.ConfigHome);

    [UnmanagedCallersOnly(EntryPoint = "xdg_state_home")]
    public static IntPtr StateHome() => StringToPtr(BaseDirectory.StateHome);

    [UnmanagedCallersOnly(EntryPoint = "xdg_bin_home")]
    public static IntPtr BinHome() => StringToPtr(BaseDirectory.BinHome);

    [UnmanagedCallersOnly(EntryPoint = "xdg_cache_home")]
    public static IntPtr CacheHome() => StringToPtr(BaseDirectory.CacheHome);

    [UnmanagedCallersOnly(EntryPoint = "xdg_runtime_dir")]
    public static IntPtr RuntimeDir() => StringToPtr(BaseDirectory.RuntimeDir);
}
#endif
