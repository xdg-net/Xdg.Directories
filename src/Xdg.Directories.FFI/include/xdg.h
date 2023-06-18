#ifndef XDG_DOTNET_H
#define XDG_DOTNET_H

#ifdef __cplusplus
extern "C" {
#endif

#include <stdint.h>

// XDG directory specifications API
//

// Wrapper for XDG directories
typedef uintptr_t xdg_directory;

// The current user's home directory
xdg_directory xdg_user_home(void);

// Base directories

xdg_directory xdg_data_home(void);

xdg_directory xdg_config_home(void);

xdg_directory xdg_state_home(void);

xdg_directory xdg_bin_home(void);

xdg_directory xdg_cache_home(void);

xdg_directory xdg_runtime_dir(void);

// User directories

xdg_directory xdg_desktop_dir(void);

xdg_directory xdg_download_dir(void);

xdg_directory xdg_documents_dir(void);

xdg_directory xdg_music_dir(void);

xdg_directory xdg_pictures_dir(void);

xdg_directory xdg_videos_dir(void);

xdg_directory xdg_templates_dir(void);

xdg_directory xdg_publicshare_dir(void);

// Frees the directory object.
void xdg_free(xdg_directory);

#endif // !XDG_DOTNET_H
#ifdef __cplusplus
}
#endif
