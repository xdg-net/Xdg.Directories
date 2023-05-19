using Xdg.Directories;

namespace Xdg.Testing.Directories;

[TestClass]
public class UserDirectory_Test
{
    [TestClass, TestCategory("Windows")]
    public class Windows
    {
        [TestMethod, TestCategory("DesktopDir")]
        public void DesktopDir_Windows_Default()
        {
            Helper.Prepare("XDG_DESKTOP_DIR", null, "Windows");
            Assert.AreEqual(GetFolderPath(SpecialFolder.Desktop), UserDirectory.DesktopDir);
        }

        [TestMethod, TestCategory("DownloadDir")]
        public void DownloadDir_Windows_Default()
        {
            Helper.Prepare("XDG_DOWNLOAD_DIR", null, "Windows");
            Assert.IsNull(UserDirectory.DownloadDir);
        }

        [TestMethod, TestCategory("DocumentsDir")]
        public void DocumentsDir_Windows_Default()
        {
            Helper.Prepare("XDG_DOCUMENTS_DIR", null, "Windows");
            Assert.AreEqual(GetFolderPath(SpecialFolder.MyDocuments), UserDirectory.DocumentsDir);
        }

        [TestMethod, TestCategory("MusicDir")]
        public void MusicDir_Windows_Default()
        {
            Helper.Prepare("XDG_MUSIC_DIR", null, "Windows");
            Assert.AreEqual(GetFolderPath(SpecialFolder.MyMusic), UserDirectory.MusicDir);
        }

        [TestMethod, TestCategory("PicturesDir")]
        public void PicturesDir_Windows_Default()
        {
            Helper.Prepare("XDG_PICTURES_DIR", null, "Windows");
            Assert.AreEqual(GetFolderPath(SpecialFolder.MyPictures), UserDirectory.PicturesDir);
        }

        [TestMethod, TestCategory("VideosDir")]
        public void VideosDir_Windows_Default()
        {
            Helper.Prepare("XDG_VIDEOS_DIR", null, "Windows");
            Assert.AreEqual(GetFolderPath(SpecialFolder.MyVideos), UserDirectory.VideosDir);
        }

        [TestMethod, TestCategory("TemplatesDir")]
        public void Templates_Windows_Default()
        {
            Helper.Prepare("XDG_TEMPLATES_DIR", null, "Windows");
            Assert.AreEqual(GetFolderPath(SpecialFolder.Templates), UserDirectory.TemplatesDir);
        }

        [TestMethod, TestCategory("PublicDir")]
        public void Public_Windows_Default()
        {
            Helper.Prepare("XDG_PUBLICSHARE_DIR", null, "Windows");
            Assert.AreEqual(GetEnvironmentVariable("PUBLIC"), UserDirectory.PublicDir);
        }
    }

    [TestClass, TestCategory("MacOS")]
    public class MacOS
    {
        [TestMethod, TestCategory("DesktopDir")]
        public void DesktopDir_MacOS_Default()
        {
            Helper.Prepare("XDG_DESKTOP_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Desktop", UserDirectory.DesktopDir);
        }

        [TestMethod, TestCategory("DownloadDir")]
        public void DownloadDir_MacOS_Default()
        {
            Helper.Prepare("XDG_DOWNLOAD_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Downloads", UserDirectory.DownloadDir);
        }

        [TestMethod, TestCategory("DocumentsDir")]
        public void DocumentsDir_MacOS_Default()
        {
            Helper.Prepare("XDG_DOCUMENTS_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Documents", UserDirectory.DocumentsDir);
        }

        [TestMethod, TestCategory("MusicDir")]
        public void MusicDir_MacOS_Default()
        {
            Helper.Prepare("XDG_MUSIC_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Music", UserDirectory.MusicDir);
        }

        [TestMethod, TestCategory("PicturesDir")]
        public void PicturesDir_MacOS_Default()
        {
            Helper.Prepare("XDG_PICTURES_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Pictures", UserDirectory.PicturesDir);
        }

        [TestMethod, TestCategory("VideosDir")]
        public void VideosDir_MacOS_Default()
        {
            Helper.Prepare("XDG_VIDEOS_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Movies", UserDirectory.VideosDir);
        }

        [TestMethod, TestCategory("TemplatesDir")]
        public void TemplatesDir_MacOS_Default()
        {
            Helper.Prepare("XDG_TEMPLATES_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Templates", UserDirectory.TemplatesDir);
        }

        [TestMethod, TestCategory("PublicDir")]
        public void PublicDir_MacOS_Default()
        {
            Helper.Prepare("XDG_PUBLIC_DIR", null, "MacOS");
            Assert.AreEqual($"{Other.Home}/Public", UserDirectory.PublicDir);
        }
    }

    [TestClass, TestCategory("Linux")]
    public class Linux
    {
        [TestMethod, TestCategory("DesktopDir")]
        public void DesktopDir_Linux_Default()
        {
            Helper.Prepare("XDG_DESKTOP_DIR", null, "Linux");
            Assert.AreEqual($"{Other.Home}/Desktop", UserDirectory.DesktopDir);
        }

        [TestMethod, TestCategory("DownloadDir")]
        public void DownloadDir_Linux_Default()
        {
            Helper.Prepare("XDG_DOWNLOAD_DIR", null, "Linux");
            Assert.AreEqual($"{Other.Home}/Downloads", UserDirectory.DownloadDir);
        }

        [TestMethod, TestCategory("DocumentsDir")]
        public void DocumentsDir_Linux_Default()
        {
            Helper.Prepare("XDG_DOCUMENTS_DIR", null, "Linux");
            Assert.AreEqual($"{Other.Home}/Documents", UserDirectory.DocumentsDir);
        }

        [TestMethod, TestCategory("MusicDir")]
        public void MusicDir_Linux_Default()
        {
            Helper.Prepare("XDG_MUSIC_DIR", null, "Linux");
            Assert.AreEqual($"{Other.Home}/Music", UserDirectory.MusicDir);
        }

        [TestMethod, TestCategory("PicturesDir")]
        public void PicturesDir_Linux_Default()
        {
            Helper.Prepare("XDG_PICTURES_DIR", null, "Linux");
            Assert.AreEqual($"{Other.Home}/Pictures", UserDirectory.PicturesDir);
        }

        [TestMethod, TestCategory("VideosDir")]
        public void VideosDir_Linux_Default()
        {
            Helper.Prepare("XDG_VIDEOS_DIR", null, "Linux");
            Assert.AreEqual($"{Other.Home}/Videos", UserDirectory.VideosDir);
        }

        [TestMethod, TestCategory("TemplatesDir")]
        public void TemplatesDir_Linux_Default()
        {
            Helper.Prepare("XDG_TEMPLATES_DIR", null, "Linux");
            Assert.AreEqual($"{Other.Home}/Templates", UserDirectory.TemplatesDir);
        }

        [TestMethod, TestCategory("PublicDir")]
        public void PublicDir_Linux_Default()
        {
            Helper.Prepare("XDG_PUBLIC_DIR", null, "Linux");
            Assert.AreEqual($"{Other.Home}/Public", UserDirectory.PublicDir);
        }
    }

    [TestClass, TestCategory("SetEnv")]
    public class Env
    {
        [TestMethod, TestCategory("DesktopDir")]
        public void DesktopDir_SetEnv()
        {
            SetEnvironmentVariable("XDG_DESKTOP_DIR", "/");
            Assert.AreEqual("/", UserDirectory.DesktopDir);
        }

        [TestMethod, TestCategory("DownloadDir")]
        public void DownloadDir_SetEnv()
        {
            SetEnvironmentVariable("XDG_DOWNLOAD_DIR", "/");
            Assert.AreEqual("/", UserDirectory.DownloadDir);
        }

        [TestMethod, TestCategory("DocumentsDir")]
        public void DocumentsDir_SetEnv()
        {
            SetEnvironmentVariable("XDG_DOCUMENTS_DIR", "/");
            Assert.AreEqual("/", UserDirectory.DocumentsDir);
        }

        [TestMethod, TestCategory("MusicDir")]
        public void MusicDir_SetEnv()
        {
            SetEnvironmentVariable("XDG_MUSIC_DIR", "/");
            Assert.AreEqual("/", UserDirectory.MusicDir);
        }

        [TestMethod, TestCategory("PicturesDir")]
        public void PicturesDir_SetEnv()
        {
            SetEnvironmentVariable("XDG_PICTURES_DIR", "/");
            Assert.AreEqual("/", UserDirectory.PicturesDir);
        }

        [TestMethod, TestCategory("VideosDir")]
        public void VideosDir_SetEnv()
        {
            SetEnvironmentVariable("XDG_VIDEOS_DIR", "/");
            Assert.AreEqual("/", UserDirectory.VideosDir);
        }

        [TestMethod, TestCategory("TemplatesDir")]
        public void Templates_SetEnv()
        {
            SetEnvironmentVariable("XDG_TEMPLATES_DIR", "/");
            Assert.AreEqual("/", UserDirectory.TemplatesDir);
        }

        [TestMethod, TestCategory("PublicDir")]
        public void Public_SetEnv()
        {
            SetEnvironmentVariable("XDG_PUBLICSHARE_DIR", "/");
            Assert.AreEqual("/", UserDirectory.PublicDir);
        }
    }
}