using System.Runtime.InteropServices;

namespace Xdg.Testing.Directories;

internal static class Helper
{
    public static void Prepare(string Env, string? EnvValue, string OS)
    {
        OSCheck(OS);
        SetEnvironmentVariable(Env, EnvValue);
    }

    public static void OSCheck(string os)
    {
        switch (os.ToLower())
        {
            case "windows":
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    Assert.Inconclusive("Not running on Windows");
                break;
            case "macos":
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    Assert.Inconclusive("Not running on macOS");
                break;
            case "linux":
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    Assert.Inconclusive("Not running on Linux");
                break;
#if NET
            case "freebsd":
                if (!OperatingSystem.IsFreeBSD())
                    Assert.Inconclusive("Not running on FreeBSD");
                break;
#endif
            default:
                Assert.Fail("Not supported");
                break;
        }
    }
}
