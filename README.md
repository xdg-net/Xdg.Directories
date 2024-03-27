# Xdg.Directories

> A .NET Standard library for the XDG Base Directory Specification and XDG user directories.

[![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/xdg-net/xdg.directories/build-test.yaml?style=for-the-badge&logo=github)](https://github.com/xdg-net/Xdg.Net/actions/workflows/build-test.yaml)
[![NuGet Version](https://img.shields.io/nuget/v/xdg.directories?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/Xdg.Directories/)
[![MIT License](https://img.shields.io/github/license/xdg-net/xdg.directories?style=for-the-badge)](https://choosealicense.com/licenses/mit/)

Xdg.Net is a ***small*** (the .dll is only 11 KB), [***fast***](https://xdg-net.github.io/Xdg.Directories/dev/bench/) and ***portable*** (Completely supports .NET Standard 2.0 and even NativeAOT!) .NET implementation of the [XDG Base Directory Specification](https://specifications.freedesktop.org/basedir-spec/basedir-spec-latest.html) and XDG user directories for Windows, MacOS and Linux/FreeBSD.

Full documentation can be found at <https://xdg-net.github.io/Xdg.Directories/>

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

Preview releases are uploaded to both [GitHub packages](https://github.com/xdg-net/Xdg.Net/pkgs/nuget/Xdg.Directories) (need GitHub account to download) and [Forgejo packages](https://git.froth.zone/mirrors/-/packages/nuget/xdg.directories) (no login required).

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

### Native Library (WIP)

[View the README here](./src/Xdg.Directories.FFI/README.md)

## License

This project is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license. \
Icon is made by Emoji One, [CC BY-SA 4.0](https://creativecommons.org/licenses/by-sa/4.0), via [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Eo_circle_purple_white_letter-x.svg) an image.
