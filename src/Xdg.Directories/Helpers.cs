namespace Xdg.Directories;

static internal class Helpers
{
    /// <summary>
    /// The current operating system
    /// </summary>
    internal enum OS : byte
    {
        Windows,
        MacOS,
        /// <summary>
        /// Linux, FreeBSD, etc.
        /// </summary>
        UnixLike,
        /// <summary>
        /// Anything not supported by the library (Android/iOS, etc.)
        /// </summary>
        Other
    }

    /// <summary>
    /// Get the current operating system
    /// </summary> 
    /// <returns>The current operating system</returns>
    internal static OS GetCurrentOperatingSystem()
    {
        // OperatingSystem.Is is faster but not supported by .NET Standard
#if NETSTANDARD
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return OS.Windows;
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return OS.MacOS;
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return OS.UnixLike;
#elif NET
        if (OperatingSystem.IsWindows())
            return OS.Windows;
        else if (OperatingSystem.IsMacOS())
            return OS.MacOS;
        else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
            return OS.UnixLike;
#endif
        else
            return OS.Other;
    }
}
