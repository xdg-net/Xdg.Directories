using Xdg.Directories;

namespace Xdg.Testing.Directories;

[TestClass]
public class BaseDirectory_Test
{
    [TestClass, TestCategory("Windows")]
    public class Windows
    {
        [TestMethod, TestCategory("DataHome")]
        public void DataHome_Windows_Default()
        {
            Helper.Prepare("XDG_DATA_HOME", null, "Windows");
            Assert.AreEqual(
                BaseDirectory.DataHome,
                GetFolderPath(SpecialFolder.LocalApplicationData)
            );
        }

        [TestMethod, TestCategory("ConfigHome")]
        public void ConfigHome_Windows_Default()
        {
            Helper.Prepare("XDG_CONFIG_HOME", null, "Windows");
            Assert.AreEqual(
                BaseDirectory.ConfigHome,
                GetFolderPath(SpecialFolder.LocalApplicationData)
            );
        }

        [TestMethod, TestCategory("StateHome")]
        public void StateHome_Windows_Default()
        {
            Helper.Prepare("XDG_STATE_HOME", null, "Windows");
            Assert.AreEqual(
                GetFolderPath(SpecialFolder.LocalApplicationData),
                BaseDirectory.StateHome
            );
        }

        [TestMethod, TestCategory("BinHome")]
        public void BinHome_Windows_Default()
        {
            Helper.Prepare("XDG_BIN_HOME", null, "Windows");
            Assert.AreEqual(string.Empty, BaseDirectory.BinHome);
        }

        [TestMethod, TestCategory("CacheHome")]
        public void CacheHome_Windows_Default()
        {
            Helper.Prepare("XDG_CACHE_HOME", null, "Windows");
            Assert.AreEqual(
                $"{GetFolderPath(SpecialFolder.LocalApplicationData)}\\cache",
                BaseDirectory.CacheHome
            );
        }

        [TestMethod, TestCategory("RuntimeDir")]
        public void RuntimeDir_Windows_Default()
        {
            Helper.Prepare("XDG_RUNTIME_DIR", null, "Windows");
            Assert.AreEqual(
                GetFolderPath(SpecialFolder.LocalApplicationData),
                BaseDirectory.RuntimeDir
            );
        }

        [TestMethod, TestCategory("DataDirs")]
        public void DataDirs_Windows_Default()
        {
            Helper.Prepare("XDG_DATA_DIRS", null, "Windows");
            Assert.AreSequenceEqual(
                new string[]
                {
                    GetEnvironmentVariable("APPDATA")!,
                    GetEnvironmentVariable("PROGRAMDATA")!
                },
                (System.Collections.ICollection)BaseDirectory.DataDirs
            );
        }

        [TestMethod, TestCategory("ConfigDirs")]
        public void ConfigDirs_Windows_Default()
        {
            Helper.Prepare("XDG_CONFIG_DIRS", null, "Windows");
            Assert.AreSequenceEqual(
                new string[]
                {
                    GetEnvironmentVariable("PROGRAMDATA")!,
                    GetEnvironmentVariable("APPDATA")!
                },
                (System.Collections.ICollection)BaseDirectory.ConfigDirs
            );
        }
    }

    [TestClass, TestCategory("MacOS")]
    public class MacOS
    {
        [TestMethod, TestCategory("DataHome")]
        public void DataHome_MacOS_Default()
        {
            Helper.Prepare("XDG_DATA_HOME", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Library/Application Support", BaseDirectory.DataHome);
        }

        [TestMethod, TestCategory("ConfigHome")]
        public void ConfigHome_MacOS_Default()
        {
            Helper.Prepare("XDG_CONFIG_HOME", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Library/Application Support", BaseDirectory.ConfigHome);
        }

        [TestMethod, TestCategory("StateHome")]
        public void StateHome_MacOS_Default()
        {
            Helper.Prepare("XDG_STATE_HOME", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Library/Application Support", BaseDirectory.StateHome);
        }

        [TestMethod, TestCategory("BinHome")]
        public void BinHome_MacOS_Default()
        {
            Helper.Prepare("XDG_BIN_HOME", null, "MacOS");
            Assert.AreEqual(string.Empty, BaseDirectory.BinHome);
        }

        [TestMethod, TestCategory("CacheHome")]
        public void CacheHome_MacOS_Default()
        {
            Helper.Prepare("XDG_CACHE_HOME", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Library/Caches", BaseDirectory.CacheHome);
        }

        [TestMethod, TestCategory("RuntimeDir")]
        public void RuntimeDir_MacOS_Default()
        {
            Helper.Prepare("XDG_RUNTIME_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Library/Application Support", BaseDirectory.RuntimeDir);
        }

        [TestMethod, TestCategory("DataDirs")]
        public void DataDirs_MacOS_Default()
        {
            Helper.Prepare("XDG_DATA_DIRS", null, "MacOS");
            Assert.AreSequenceEqual(
                new string[] { "/Library/Application Support" }, (System.Collections.ICollection)BaseDirectory.DataDirs
            );
        }

        [TestMethod, TestCategory("ConfigDirs")]
        public void ConfigDirs_MacOS_Default()
        {
            Helper.Prepare("XDG_CONFIG_DIRS", null, "MacOS");
            Assert.AreSequenceEqual(
                new string[]
                {
                    $"{Other.Home}/Library/Preferences",
                    "/Library/Application Support",
                    "/Library/Preferences"
                }, (System.Collections.ICollection)BaseDirectory.ConfigDirs
            );
        }
    }

    [TestClass, TestCategory("Linux")]
    public class Linux
    {
        [TestMethod, TestCategory("DataHome")]
        public void DataHome_Linux_Default()
        {
            Helper.Prepare("XDG_DATA_HOME", null, "Linux");
            Assert.AreEqual($"{Other.Home}/.local/share", BaseDirectory.DataHome);
        }

        [TestMethod, TestCategory("ConfigHome")]
        public void ConfigHome_Linux_Default()
        {
            Helper.Prepare("XDG_CONFIG_HOME", null, "Linux");
            Assert.AreEqual($"{Other.Home}/.config", BaseDirectory.ConfigHome);
        }

        [TestMethod, TestCategory("StateHome")]
        public void StateHome_Linux_Default()
        {
            Helper.Prepare("XDG_STATE_HOME", null, "Linux");
            Assert.AreEqual($"{Other.Home}/.local/state", BaseDirectory.StateHome);
        }

        [TestMethod, TestCategory("BinHome")]
        public void BinHome_Linux_Default()
        {
            Helper.Prepare("XDG_BIN_HOME", null, "Linux");
            Assert.AreEqual($"{Other.Home}/.local/bin", BaseDirectory.BinHome);
        }

        [TestMethod, TestCategory("CacheHome")]
        public void CacheHome_Linux_Default()
        {
            Helper.Prepare("XDG_CACHE_HOME", null, "Linux");
            Assert.AreEqual($"{Other.Home}/.cache", BaseDirectory.CacheHome);
        }

        [TestMethod, TestCategory("RuntimeDir")]
        public void RuntimeDir_Linux_Default()
        {
            Helper.Prepare("XDG_RUNTIME_DIR", null, "Linux");
            Assert.AreEqual($"/run/user/{GetEnvironmentVariable("UID") ?? "0"}", BaseDirectory.RuntimeDir);
        }

        [TestMethod, TestCategory("DataDirs")]
        public void DataDirs_Linux_Default()
        {
            Helper.Prepare("XDG_DATA_DIRS", null, "Linux");
            Assert.AreSequenceEqual(
                new string[] { "/usr/local/share", "/usr/share" },
                (System.Collections.ICollection)BaseDirectory.DataDirs
            );
        }

        [TestMethod, TestCategory("ConfigDirs")]
        public void ConfigDirs_Linux_Default()
        {
            Helper.Prepare("XDG_CONFIG_DIRS", null, "Linux");
            Assert.AreSequenceEqual(
                new string[] { "/etc/xdg" }, (System.Collections.ICollection)BaseDirectory.ConfigDirs
            );
        }
    }

    [TestClass, TestCategory("SetEnv")]
    public class Env
    {
        [TestMethod, TestCategory("DataHome")]
        public void DataHome_SetEnv()
        {
            Assert.AreNotEqual("/", BaseDirectory.DataHome);
            SetEnvironmentVariable("XDG_DATA_HOME", "/");
            Assert.AreEqual("/", BaseDirectory.DataHome);
        }

        [TestMethod, TestCategory("ConfigHome")]
        public void ConfigHome_SetEnv()
        {
            Assert.AreNotEqual("/", BaseDirectory.ConfigHome);
            SetEnvironmentVariable("XDG_CONFIG_HOME", "/");
            Assert.AreEqual("/", BaseDirectory.ConfigHome);
        }

        [TestMethod, TestCategory("StateHome")]
        public void StateHome_SetEnv()
        {
            Assert.AreNotEqual("/", BaseDirectory.StateHome);
            SetEnvironmentVariable("XDG_STATE_HOME", "/");
            Assert.AreEqual("/", BaseDirectory.StateHome);
        }

        [TestMethod, TestCategory("BinHome")]
        public void BinHome_SetEnv()
        {
            Assert.AreNotEqual("/", BaseDirectory.BinHome);
            SetEnvironmentVariable("XDG_BIN_HOME", "/");
            Assert.AreEqual("/", BaseDirectory.BinHome);
        }

        [TestMethod, TestCategory("CacheHome")]
        public void CacheHome_SetEnv()
        {
            Assert.AreNotEqual("/", BaseDirectory.CacheHome);
            SetEnvironmentVariable("XDG_CACHE_HOME", "/");
            Assert.AreEqual("/", BaseDirectory.CacheHome);
        }

        [TestMethod, TestCategory("RuntimeDir")]
        public void RuntimeDir_SetEnv()
        {
            Assert.AreNotEqual("/", BaseDirectory.RuntimeDir);
            SetEnvironmentVariable("XDG_RUNTIME_DIR", "/");
            Assert.AreEqual("/", BaseDirectory.RuntimeDir);
        }

        [TestMethod, TestCategory("DataDirs")]
        public void DataDirs_SetEnv()
        {
            Assert.AreNotSequenceEqual(new string[] { "/", "/" }, BaseDirectory.DataDirs);
            SetEnvironmentVariable("XDG_DATA_DIRS", "/:/");
            Assert.AreSequenceEqual(
                new string[] { "/", "/" },
                (System.Collections.ICollection)BaseDirectory.DataDirs
            );
        }

        [TestMethod, TestCategory("DataDirs")]
        public void ConfigDirs_SetEnv()
        {
            Assert.AreNotSequenceEqual(new string[] { "/", "/", "/" }, BaseDirectory.ConfigDirs);
            SetEnvironmentVariable("XDG_CONFIG_DIRS", "/:/:/");
            Assert.AreSequenceEqual(
                new string[] { "/", "/", "/" },
                (System.Collections.ICollection)BaseDirectory.ConfigDirs
            );
        }
    }
}
