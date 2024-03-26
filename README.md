# Xdg.Directories

> A .NET Standard library for the XDG Base Directory Specification and XDG user directories.

[![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/xdg-net/xdg.directories/build-test.yaml?style=for-the-badge&logo=github)](https://github.com/xdg-net/Xdg.Net/actions/workflows/build-test.yaml)
[![NuGet Version](https://img.shields.io/nuget/v/xdg.directories?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/Xdg.Directories/)
[![MIT License](https://img.shields.io/github/license/xdg-net/xdg.directories?style=for-the-badge)](https://choosealicense.com/licenses/mit/)

Xdg.Net is a ***small*** (the .dll is only 11 KB), [***fast***](./src/Xdg.Benchmarks/README.md) and ***portable*** (Completely supports .NET Standard 2.0 and even NativeAOT!) .NET implementation of the [XDG Base Directory Specification](https://specifications.freedesktop.org/basedir-spec/basedir-spec-latest.html) and XDG user directories for Windows, MacOS and Linux/FreeBSD.

## Installation

Use [NuGet](http://docs.nuget.org/docs/start-here/installing-nuge) to install [Xdg.Directories](thttps://www.nuget.org/packages/Xdg.Directories).

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

### Base Directories, C#

```csharp
using System;
using Xdg.Directories;

// Prints /home/$USER/.local/share
Console.Writeline(BaseDirectory.DataHome);

// Prints /home/$USER/.cache
Console.Writeline(BaseDirectory.CacheHome)
```

### User Directories, F#

```fsharp
open Xdg.Directories

// Prints /home/$USER/Documents
printfn "%s" UserDirectory.DesktopDir
```

## Default Locations

If any of the respective XDG environment are specified, the variable will always be returned.
Otherwise, the value depends on the operating system.

Inspiration is taken from the [Go implementation](https://github.com/adrg/xdg) for Windows and MacOS directories.

<details open>
<summary>Base Directory</summary>

| Environment Variable | Windows | macOS | Linux/FreeBSD |
| --- | --- | --- | --- |
| `XDG_DATA_HOME` | `%LOCALAPPDATA%` | `$HOME/Library/Application Support` | `$HOME/.local/share` |
| `XDG_CONFIG_HOME` | `%LOCALAPPDATA%` | `$HOME/Library/Application Support` | `$HOME/.config` |
| `XDG_STATE_HOME` | `%LOCALAPPDATA%` | `$HOME/Library/Application Support` | `$HOME/.local/state` |
| `XDG_BIN_HOME` | `null` | `null` | `$HOME/.local/bin` |
| `XDG_DATA_DIRS` | `%APPDATA%:%PROGRAMDATA%` | `/Library/Application Support` | `/usr/local/share:/usr/share` |
| `XDG_CONFIG_DIRS` | `%LOCALAPPDATA%` | `$HOME/Library/Preferences:/Library/Application Support:/Library/Preferences` | `/etc/xdg` |
| `XDG_CACHE_HOME` | `%LOCALAPPDATA%` | `$HOME/Library/Application Support` | `$HOME/.config` |
| `XDG_RUNTIME_HOME` | `%LOCALAPPDATA%` | `$HOME/Library/Application Support` | `/run/user/$UID` |
</details>

<details open>
<summary>User Directory</summary>

User directories on Windows use [Known Folders](https://learn.microsoft.com/en-us/windows/win32/shell/known-folders).
| Environment Variable | Windows | macOS | Linux/FreeBSD |
| --- | --- | --- | --- |
| `XDG_DESKTOP_DIR` | `Desktop` | `$HOME/Desktop` | `$HOME/Desktop` |
| `XDG_DOWNLOAD_DIR` | `null` | `$HOME/Downloads` | `$HOME/Downloads` |
| `XDG_DOCUMENTS_DIR` | `My Documents` | `$HOME/Documents` | `$HOME/Documents` |
| `XDG_MUSIC_DIR` | `My Music` | `$HOME/Music` | `$HOME/Music` |
| `XDG_PICTURES_DIRS` | `My Pictures` | `$HOME/Pictures` | `$HOME/Pictures` |
| `XDG_VIDEOS_DIR` | `My Videos` | `$HOME/Movies` | `$HOME/Videos` |
| `XDG_TEMPLATES_DIR` | `Templates` | `$HOME/Templates` | `$HOME/Templates` |
| `XDG_PUBLICSHARE_DIR` | `%PUBLIC%` | `$HOME/Public` | `$HOME/Public` |
</details>

<details open>
<summary>Extra Directories</summary>

| | Windows | macOS | Linux/FreeBSD |
| --- | --- | --- | --- |
| Home | `%USERPROFILE%` | `$HOME` | `$HOME` |
</details>

### Native Library (WIP)

[View the README here](./src/Xdg.Directories.FFI/README.md)

## License

[MIT](https://choosealicense.com/licenses/mit/) \
Icon is made by Emoji One, [CC BY-SA 4.0](https://creativecommons.org/licenses/by-sa/4.0), via [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Eo_circle_purple_white_letter-x.svg)