#if NET7_0_OR_GREATER
using System.Runtime.InteropServices;

namespace Xdg.Directories.FFI;

internal static partial class Exports
{
    /// <summary>
    /// Frees the specified pointer
    /// </summary>
    /// <remarks>
    /// CALL THIS EVERY SINGLE TIME YOU USE SOMETHING FROM THIS LIBRARY!!!!!! <br />
    /// You <em>will</em> leak memory otherwise.
    /// </remarks>
    /// <param name="p">The .NET Pointer to free</param>
    [UnmanagedCallersOnly(EntryPoint = "xdg_free")]
    public static void Free(IntPtr p) => Marshal.FreeCoTaskMem(p);

    /// <summary>
    /// Converts a .NET string to a C string
    /// </summary>
    /// <param name="str">The .NET string</param>
    /// <returns>A pointer to a C string</returns>
    internal static IntPtr StringToPtr(string? str) => Marshal.StringToCoTaskMemUTF8(str);
}
#endif
