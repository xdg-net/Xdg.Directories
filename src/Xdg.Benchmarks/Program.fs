open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open BenchmarkDotNet.Jobs
open Xdg.Directories;

[<MemoryDiagnoser>]
//[<SimpleJob(RuntimeMoniker.Mono)>]
[<SimpleJob(RuntimeMoniker.Net462)>]
[<SimpleJob(RuntimeMoniker.Net70, baseline = true)>]
[<SimpleJob(RuntimeMoniker.NativeAot70)>]
[<JsonExporterAttribute.Full>]
[<JsonExporterAttribute.FullCompressed>]
type Benchmarks() =
    // Base Directory
    [<Benchmark>]
    member _.DataHome () = BaseDirectory.DataHome
    [<Benchmark>]
    member _.ConfigHome () = BaseDirectory.ConfigHome
    [<Benchmark>]
    member _.StateHome () = BaseDirectory.StateHome
    [<Benchmark>]
    member _.BinHome () = BaseDirectory.BinHome
    [<Benchmark>]
    member _.DataDirs () = BaseDirectory.DataDirs
    [<Benchmark>]
    member _.ConfigDirs () = BaseDirectory.ConfigDirs
    [<Benchmark>]
    member _.CacheHome () = BaseDirectory.CacheHome
    [<Benchmark>]
    member _.RuntimeDir() = BaseDirectory.RuntimeDir

    // User Directories
    [<Benchmark>]
    member _.DesktopDir () = UserDirectory.DesktopDir
    [<Benchmark>]
    member _.DownloadDir () = UserDirectory.DownloadDir
    [<Benchmark>]
    member _.DocumentsDir () = UserDirectory.DocumentsDir
    [<Benchmark>]
    member _.MusicDir () = UserDirectory.MusicDir
    [<Benchmark>]
    member _.PicturesDir () = UserDirectory.PicturesDir
    [<Benchmark>]
    member _.VideosDir () = UserDirectory.VideosDir
    [<Benchmark>]
    member _.TemplatesDir () = UserDirectory.TemplatesDir
    [<Benchmark>]
    member _.PublicDir () = UserDirectory.PublicDir

    // Other
    [<Benchmark>]
    member _.Home () = Other.Home
    [<Benchmark>]
    member _.Applications () = Other.Applications
    [<Benchmark>]
    member _.Fonts () = Other.Fonts

BenchmarkRunner.Run<Benchmarks>() |> ignore