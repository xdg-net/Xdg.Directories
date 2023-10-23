# Xdg.Benchmarks
Here lies the benchmarks for all [Xdg.Directories](../../README.md) functions.

## Results
```

BenchmarkDotNet v0.13.8, Gentoo Linux
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2 DEBUG
  .NET 7.0 : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
| Method       | Mean     | Error   | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------- |---------:|--------:|---------:|------:|--------:|-------:|----------:|------------:|
| DataHome     | 198.0 ns | 1.80 ns |  1.60 ns |  1.00 |    0.00 | 0.0043 |      72 B |        1.00 |
| ConfigHome   | 225.8 ns | 1.08 ns |  1.01 ns |  1.14 |    0.01 | 0.0038 |      64 B |        0.89 |
| StateHome    | 229.9 ns | 2.05 ns |  1.92 ns |  1.16 |    0.02 | 0.0043 |      72 B |        1.00 |
| BinHome      | 215.0 ns | 4.10 ns |  3.83 ns |  1.09 |    0.02 | 0.0038 |      64 B |        0.89 |
| DataDirs     | 181.7 ns | 3.54 ns |  3.48 ns |  0.92 |    0.02 | 0.0024 |      40 B |        0.56 |
| ConfigDirs   | 179.8 ns | 1.57 ns |  1.39 ns |  0.91 |    0.01 | 0.0019 |      32 B |        0.44 |
| CacheHome    | 178.7 ns | 1.10 ns |  0.98 ns |  0.90 |    0.01 | 0.0033 |      56 B |        0.78 |
| RuntimeDir   | 207.9 ns | 1.67 ns |  1.57 ns |  1.05 |    0.01 | 0.0033 |      56 B |        0.78 |
| DesktopDir   | 382.8 ns | 2.58 ns |  2.29 ns |  1.93 |    0.02 | 0.0067 |     112 B |        1.56 |
| DownloadDir  | 380.5 ns | 4.02 ns |  3.76 ns |  1.92 |    0.03 | 0.0067 |     112 B |        1.56 |
| DocumentsDir | 378.6 ns | 1.44 ns |  1.34 ns |  1.91 |    0.02 | 0.0067 |     112 B |        1.56 |
| MusicDir     | 372.5 ns | 2.78 ns |  2.32 ns |  1.88 |    0.02 | 0.0062 |     104 B |        1.44 |
| PicturesDir  | 379.9 ns | 2.51 ns |  1.96 ns |  1.92 |    0.02 | 0.0067 |     112 B |        1.56 |
| VideosDir    | 382.0 ns | 3.20 ns |  2.99 ns |  1.93 |    0.03 | 0.0062 |     104 B |        1.44 |
| TemplatesDir | 390.3 ns | 3.43 ns |  3.04 ns |  1.97 |    0.02 | 0.0067 |     112 B |        1.56 |
| PublicDir    | 371.9 ns | 4.49 ns |  3.75 ns |  1.88 |    0.02 | 0.0062 |     104 B |        1.44 |
| Home         | 151.2 ns | 2.96 ns |  3.53 ns |  0.77 |    0.02 | 0.0029 |      48 B |        0.67 |
| Applications | 403.2 ns | 7.98 ns | 12.42 ns |  2.03 |    0.08 | 0.0219 |     368 B |        5.11 |
| Fonts        | 615.7 ns | 9.39 ns |  8.79 ns |  3.12 |    0.05 | 0.0267 |     448 B |        6.22 |
