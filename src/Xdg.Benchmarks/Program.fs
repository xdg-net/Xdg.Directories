open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open BenchmarkDotNet.Jobs
open Xdg.Directories

[<MemoryDiagnoser>]
#if WINDOWS
[<SimpleJob(RuntimeMoniker.Net481)>]
#endif
[<SimpleJob(RuntimeMoniker.Net80, baseline=true)>]
// [<SimpleJob(RuntimeMoniker.NativeAot80)>]
[<JsonExporterAttribute.Full>]
type Benchmarks() =
    // Base Directory
    [<Benchmark(Baseline=true)>]
    member _.DataHome () = BaseDirectory.DataHome
    //[<Benchmark>]
    //member _.ConfigHome () = BaseDirectory.ConfigHome
    //[<Benchmark>]
    //member _.StateHome () = BaseDirectory.StateHome
    //[<Benchmark>]
    //member _.BinHome () = BaseDirectory.BinHome
    //[<Benchmark>] 
    //member _.DataDirs () = BaseDirectory.DataDirs
    // [<Benchmark>]
    // member _.ConfigDirs () = BaseDirectory.ConfigDirs
    //[<Benchmark>]
    //member _.CacheHome () = BaseDirectory.CacheHome
    //[<Benchmark>]
    //member _.RuntimeDir() = BaseDirectory.RuntimeDir

    // User Directories
    // [<Benchmark>]
    // member _.DesktopDir () = UserDirectory.DesktopDir
    //[<Benchmark>]
    //member _.DownloadDir () = UserDirectory.DownloadDir
    //[<Benchmark>]
    //member _.DocumentsDir () = UserDirectory.DocumentsDir
    //[<Benchmark>]
    //member _.MusicDir () = UserDirectory.MusicDir
    //[<Benchmark>]
    //member _.PicturesDir () = UserDirectory.PicturesDir
    //[<Benchmark>]
    //member _.VideosDir () = UserDirectory.VideosDir
    //[<Benchmark>]
    //member _.TemplatesDir () = UserDirectory.TemplatesDir
    //[<Benchmark>]
    //member _.PublicDir () = UserDirectory.PublicDir

    // Other
    // [<Benchmark>]
    // member _.Home () = Other.Home
    //[<Benchmark>]
    //member _.Applications () = Other.Applications
    //[<Benchmark>]
    //member _.Fonts () = Other.Fonts

BenchmarkRunner.Run<Benchmarks>() |> ignore