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

// A convenience function to get the string representation of a directory.
// You still need to call xdg_free on the original directory object.
static inline char* xdg_to_string(xdg_directory dir) { return (char* dir) };

// Frees the directory object.
//
// This must be called after the directory is no longer needed.
// Note: the CLR will leak about a megabyte of memory by existing.
void xdg_free(xdg_directory);

#ifdef __cplusplus
}
#endif

#endif // !XDG_DOTNET_H