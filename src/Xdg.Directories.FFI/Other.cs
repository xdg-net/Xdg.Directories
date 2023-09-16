#if NET7_0_OR_GREATER
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
