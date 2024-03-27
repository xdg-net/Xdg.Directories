# Default Locations

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

Environment Variable | Windows | macOS | Linux/FreeBSD |
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
| Applications | `Programs`, `Common Programs` | `/Applications` | `$XDG_DATA_HOME/applications`, `$HOME/.local/share/applications`, `/usr/local/share/applications`, `/usr/share/applications` |
| Fonts | `%SYSTEMROOT%\Fonts`, `%LOCALAPPDATA%\Microsoft\Windows\Fonts` | `$HOME/Library/Fonts`, `/Library/Fonts`, `/System/Library/Fonts`, `/Network/Library/Fonts` | `$XDG_DATA_HOME/fonts`, `$HOME/.fonts`, `$HOME/.local/share/fonts`, `/usr/local/share/fonts`, `/usr/share/fonts` |
</details>
