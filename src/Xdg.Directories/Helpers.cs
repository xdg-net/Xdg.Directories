using System.Runtime.InteropServices;

namespace Xdg.Directories;
static internal class Helpers
{
    /// <summary>
    /// Return a specified value depending on the running operating system
    /// </summary>
    /// <param name="Env">Environment variable to test initially</param>
    /// <param name="Windows">Windows directory</param>
    /// <param name="MacOS">macOS Directory</param>
    /// <param name="Unix">Linux/BSD Directory</param>
    /// <returns><c>Env</c> if set, otherwise variable depending on operating system</returns>
    /// <exception cref="NotSupportedException">If running on another operating system</exception>
    internal static string? OS(string Env, string? Windows, string? MacOS, string? Unix)
    {
        string? env = GetEnvironmentVariable(Env);
        if (env is not null)
            return env;
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return Windows;
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return MacOS;
#if NETSTANDARD
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
#elif NET
        else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
#endif
            return Unix;
        else
            throw new NotSupportedException("Platforms not supported by .NET Standard are not supported.");
    }

    /// <summary>
    /// Return a specified value depending on the running operating system
    /// </summary>
    /// <param name="Env">Environment variable to test initially</param>
    /// <param name="Windows">Windows directories</param>
    /// <param name="MacOS">macOS Directories</param>
    /// <param name="Unix">Linux/BSD Directories</param>
    /// <returns><c>Env</c> if set, otherwise variable depending on operating system</returns>
    /// <exception cref="NotSupportedException">If running on another operating system</exception>
    internal static IList<string>? OS(string Env, IList<string>? Windows, IList<string>? MacOS, IList<string>? Unix)
    {
        string? env = GetEnvironmentVariable(Env);
        if (env is not null)
            return env.Split(':')!;
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return Windows;
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return MacOS;
#if NETSTANDARD
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
#elif NET
        else if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
#endif
            return Unix;
        else
            throw new NotSupportedException("Platforms not supported by .NET Standard are not supported.");
    }

    /// <summary>
    /// Returns B if and only if A is empty.
    /// </summary>
    /// <param name="A">Value to test</param>
    /// <param name="B">Alternative if A is null or empty</param>
    /// <returns>B if A is null or empty, A if not</returns>
    internal static string AorB(string A, string B)
        => A is { Length: 0 } ? B : A;
}
