# Xdg.Directories

> A .NET Standard library for the XDG Base Directory Specification and XDG user directories.

[![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/xdg-net/xdg.directories/build-test.yaml?style=for-the-badge&logo=github)](https://github.com/xdg-net/Xdg.Directories/actions/workflows/build-test.yaml)
[![NuGet Version](https://img.shields.io/nuget/v/xdg.directories?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/Xdg.Directories/)
[![Documentation](https://img.shields.io/badge/docfx-Docs-3391ff.svg?style=for-the-badge&logo=data:image/svg%2bxml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBzdGFuZGFsb25lPSJubyI/Pgo8IURPQ1RZUEUgc3ZnIFBVQkxJQyAiLS8vVzNDLy9EVEQgU1ZHIDIwMDEwOTA0Ly9FTiIKICJodHRwOi8vd3d3LnczLm9yZy9UUi8yMDAxL1JFQy1TVkctMjAwMTA5MDQvRFREL3N2ZzEwLmR0ZCI+CjxzdmcgdmVyc2lvbj0iMS4wIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciCiB3aWR0aD0iMzguMDAwMDAwcHQiIGhlaWdodD0iMzguMDAwMDAwcHQiIHZpZXdCb3g9IjAgMCAxNzIuMDAwMDAwIDE3Mi4wMDAwMDAiCiBwcmVzZXJ2ZUFzcGVjdFJhdGlvPSJ4TWlkWU1pZCBtZWV0Ij4KPG1ldGFkYXRhPgpDcmVhdGVkIGJ5IERvY2Z4CjwvbWV0YWRhdGE+CjxnIHRyYW5zZm9ybT0idHJhbnNsYXRlKDAuMDAwMDAwLDE3Mi4wMDAwMDApIHNjYWxlKDAuMTAwMDAwLC0wLjEwMDAwMCkiCmZpbGw9IiNkZGRkZGQiIHN0cm9rZT0ibm9uZSI+CjxwYXRoIGQ9Ik0yMzAgMTM1OSBjMCAtMTggMTEgLTMwIDQ0IC00OCA4MCAtNDIgODEgLTQ1IDgxIC00NDEgMCAtNDAwIC0xCi00MDQgLTc5IC00MzYgLTM2IC0xNSAtNDYgLTI0IC00NiAtNDMgMCAtMjMgMiAtMjQgNjEgLTE3IDM0IDMgODggNiAxMjAgNgpsNTkgMCAwIDQ5NSAwIDQ5NSAtODIgMCBjLTQ2IDAgLTEwMCAzIC0xMjAgNiAtMzUgNiAtMzggNSAtMzggLTE3eiIvPgo8cGF0aCBkPSJNNjE4IDEzNzMgbC0xMTggLTQgMCAtNDkzIDAgLTQ5NCAxNTQgLTcgYzE4MSAtOSAyMzUgLTMgMzEzIDM0IDY4CjMzIDE2OCAxMzAgMjA3IDIwMiA3NSAxMzYgNzUgMzg0IDEgNTM2IC03MSAxNDUgLTIzNCAyNDAgLTM5OSAyMzEgLTIzIC0xIC05NAotNCAtMTU4IC01eiBtMjg3IC0xMTkgYzY4IC0yNCAxNDQgLTEwMSAxNzYgLTE3OSAyMiAtNTQgMjQgLTc1IDI0IC0yMTAgMAotMTQxIC0yIC0xNTMgLTI2IC0yMDYgLTM2IC03NiAtODkgLTEzMiAtMTUyIC0xNjAgLTQ1IC0yMSAtNjggLTI0IC0xNjQgLTI0Ci03MSAwIC0xMTYgNCAtMTIzIDExIC0yMiAyMiAtMzEgMTc1IC0yOCA0NjMgMiAyMDggNiAyOTMgMTUgMzAyIDMyIDMyIDE4OCAzMwoyNzggM3oiLz4KPHBhdGggZD0iTTExNzAgMTIyOCBjNzUgLTEwNCAxMTAgLTMzNyA3NiAtNTA4IC0yMSAtMTAwIC01NiAtMTc4IC0xMDUgLTIzMwpsLTM2IC00MSAzNCAyMCBjNzUgNDMgMTYwIDEzMyAxOTggMjEyIDM3IDc1IDM4IDc4IDM4IDE5MSAtMSAxMjkgLTE4IDE5MSAtNzUKMjcwIC0yOCAzOCAtMTM2IDEzMSAtMTUzIDEzMSAtNCAwIDYgLTE5IDIzIC00MnoiLz4KPC9nPgo8L3N2Zz4K)](https://xdg-net.github.io/Xdg.Directories/)
[![MIT License](https://img.shields.io/github/license/xdg-net/xdg.directories?style=for-the-badge)](https://choosealicense.com/licenses/mit/)

Xdg.Directories is a ***small*** (the .dll is only 11 KB), [***fast***](https://xdg-net.github.io/Xdg.Directories/dev/bench/) and ***portable*** (Completely supports .NET Standard 2.0 and even NativeAOT!) .NET implementation of the [XDG Base Directory Specification](https://specifications.freedesktop.org/basedir-spec/basedir-spec-latest.html) and XDG user directories for Windows, MacOS and Linux/FreeBSD.

Full documentation can be found at <https://xdg-net.github.io/Xdg.Directories>.

## Installation

Use [NuGet](http://docs.nuget.org/docs/start-here/installing-nuget) to install [Xdg.Directories](thttps://www.nuget.org/packages/Xdg.Directories).

From the .NET CLI:

```bash
dotnet add package Xdg.Directories
```

or from Visual Studio's package manager:

```pwsh
Install-Package Xdg.Directories
```

### Pre-releases

Preview releases are uploaded to both [GitHub packages](https://github.com/xdg-net/Xdg.Directories/pkgs/nuget/Xdg.Directories) (need GitHub account to download) and [Forgejo packages](https://git.froth.zone/mirrors/-/packages/nuget/xdg.directories) (no login required).

## Usage

### Base Directories, C\#

```cs
using System;
using Xdg.Directories;

// Prints /home/$USER/.local/share
Console.Writeline(BaseDirectory.DataHome);

// Prints /home/$USER/.cache
Console.Writeline(BaseDirectory.CacheHome)
```

### User Directories, F\#

```fsharp
open Xdg.Directories

// Prints /home/$USER/Documents
printfn "%s" UserDirectory.DesktopDir
```

## License

This project is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license. \
Icon is made by Emoji One, [CC BY-SA 4.0](https://creativecommons.org/licenses/by-sa/4.0), via [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Eo_circle_purple_white_letter-x.svg) an image.
