using Xdg.Directories;

namespace Xdg.Testing.Directories;

[TestClass]
public class Other_Test
{
    [TestClass, TestCategory("Windows")]
    public class Windows
    {
        [TestMethod, TestCategory("Home")]
        public void Home_Windows_Default()
        {
            Helper.Prepare("DISCARD", null, "Windows");
            Assert.AreEqual(GetEnvironmentVariable("USERPROFILE"), Other.Home);
        }

        [TestMethod, TestCategory("Home")]
        public void Home_Windows_NoUserProfile()
        {
            Helper.Prepare("USERPROFILE", null, "Windows");
            Assert.AreEqual(GetFolderPath(SpecialFolder.UserProfile), Other.Home);
        }

        [TestMethod, TestCategory("Applications")]
        public void Applications_Windows_Default()
        {
            Helper.Prepare("DISCARD", null, "Windows");
            CollectionAssert.AreEquivalent(new string[] { GetFolderPath(SpecialFolder.Programs), GetFolderPath(SpecialFolder.CommonPrograms) }, (System.Collections.ICollection)Other.Applications);
        }

        [TestMethod, TestCategory("Fonts")]
        public void Fonts_Windows_Default()
        {
            Helper.Prepare("DISCARD", null, "Windows");
            CollectionAssert.AreEquivalent(new string[] { GetFolderPath(SpecialFolder.Fonts), $"{GetFolderPath(SpecialFolder.LocalApplicationData)}\\Microsoft\\Windows\\Fonts" }, (System.Collections.ICollection)Other.Fonts);
        }
    }

    [TestClass, TestCategory("MacOS")]
    public class MacOS
    {
        [TestMethod, TestCategory("Home")]
        public void Home_MacOS_Default()
        {
            Helper.Prepare("DISCARD", null, "macOS");
            Assert.AreEqual(GetEnvironmentVariable("HOME"), Other.Home);
        }

        [TestMethod, TestCategory("Home")]
        public void Home_MacOS_NoHome()
        {
            Helper.Prepare("HOME", null, "macOS");
            Assert.AreEqual(GetFolderPath(SpecialFolder.UserProfile), Other.Home);
        }

        [TestMethod, TestCategory("Applications")]
        public void Applications_MacOS_Default()
        {
            Helper.Prepare("DISCARD", null, "macOS");
            CollectionAssert.AreEquivalent(new string[] { "/Applications" }, (System.Collections.ICollection)Other.Applications);
        }

        [TestMethod, TestCategory("Fonts")]
        public void Fonts_MacOS_Default()
        {
            Helper.Prepare("DISCARD", null, "macOS");
            CollectionAssert.AreEquivalent(new string[] { $"{Other.Home}/Library/Fonts", "/Library/Fonts", "/System/Library/Fonts", "/Network/Library/Fonts" }, (System.Collections.ICollection)Other.Fonts);
        }
    }

    [TestClass, TestCategory("Linux")]
    public class Linux
    {
        [TestMethod, TestCategory("Home")]
        public void Home_Linux_Default()
        {
            Helper.Prepare("DISCARD", null, "Linux");
            Assert.AreEqual(GetEnvironmentVariable("HOME"), Other.Home);
        }

        [TestMethod, TestCategory("Home")]
        public void Home_Linux_NoHome()
        {
            Helper.Prepare("HOME", null, "Linux");
            Assert.AreEqual(GetFolderPath(SpecialFolder.UserProfile), Other.Home);
        }

        [TestMethod, TestCategory("Applications")]
        public void Applications_Linux_Default()
        {
            Helper.Prepare("DISCARD", null, "Linux");
            CollectionAssert.AreEquivalent(new string[] { $"{BaseDirectory.DataHome}/applications", $"{Other.Home}/.local/share/applications", "/usr/local/share/applications", "/usr/share/applications", }, (System.Collections.ICollection)Other.Applications);
        }

        [TestMethod, TestCategory("Fonts")]
        public void Fonts_Linux_Default()
        {
            Helper.Prepare("DISCARD", null, "Linux");
            CollectionAssert.AreEquivalent(new string[] { $"{BaseDirectory.DataHome}/fonts", $"{Other.Home}/.fonts", $"{Other.Home}/.local/share/fonts", "/usr/local/share/fonts", "/usr/share/fonts", }, (System.Collections.ICollection)Other.Fonts);
        }
    }
}
