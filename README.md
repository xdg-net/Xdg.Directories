# Xdg
----
[![Drone Build Status](https://ci.git.froth.zone/api/badges/sam/Xdg.Net/status.svg)](https://ci.git.froth.zone/sam/Xdg.Net)
[![GitHub Actions Build](https://github.com/xdg-net/Xdg.Net/actions/workflows/build-test.yaml/badge.svg)](https://github.com/xdg-net/Xdg.Net/actions/workflows/build-test.yaml)
[![GitHub Actions CodeQL](https://github.com/xdg-net/Xdg.Net/actions/workflows/codeql.yml/badge.svg)](https://github.com/xdg-net/Xdg.Net/actions/workflows/codeql.yml)
![Nuget](https://img.shields.io/nuget/v/Xdg.Net)


A .NET (and an experimental C-compatible FFI) implementation of the [XDG Base Directory Specification](https://specifications.freedesktop.org/basedir-spec/basedir-spec-latest.html) and XDG user directories.

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

User directories on Windows use [Known Folders](https://learn.microsoft.com/en-us/windows/win32/shell/known-folders) as a fallback.
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

## Packaging
Stable releases will be uploaded to nuget.org, and preview releases are uploaded to both [GitHub packages](https://github.com/xdg-net/Xdg.Net/pkgs/nuget/Xdg.Directories) (need GitHub account to download) and [Gitea packages](https://git.froth.zone/sam/-/packages/nuget/xdg.directories) (no login required).

```pwsh
dotnet add package Xdg.Directories
```

### Native Library
[View the README here](./src/Xdg.Directories.FFI/README.md)

## License
[MIT](./LICENSE)