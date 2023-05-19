#if NET7_0_OR_GREATER
#pragma warning disable CA1031 // General exceptions needed for handling errors
using System.Runtime.InteropServices;

namespace Xdg.Directories.FFI;
internal static partial class Exports
{
    [UnmanagedCallersOnly(EntryPoint = "xdg_user_home")]
    public static IntPtr UserHome()
    {
        try
        {
            return StringToPtr(Other.Home);
        }
        catch
        {
            return IntPtr.Zero;
        }
    }
}
#endif