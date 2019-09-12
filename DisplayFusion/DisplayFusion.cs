using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface BFS
    {/// <summary> 
     /// This disables the Multi-Monitor Taskbar feature in DisplayFusion.
     /// </summary> 
        static bool DisableAllTaskbars();

        /// <summary> 
        /// This disables a Taskbar on a specific monitor.
        /// </summary> 
        static bool DisableTaskbar(uint monitorID);

        /// <summary> 
        /// This enables the Multi-Monitor Taskbar feature in DisplayFusion.
        /// </summary> 
        static bool EnableAllTaskbars();

        /// <summary> 
        /// This enables a Taskbar on a specific monitor and sets the position to automatic.
        /// </summary> 
        static bool EnableTaskbar(uint monitorID);

        /// <summary> 
        /// This enables a Taskbar on a specific monitor and sets the position (side) to one of these values: A, T, B, L, R (automatic, top, bottom, left, or right)
        /// </summary> 
        static bool EnableTaskbarOnSide(uint monitorID, string side);

        /// <summary> 
        /// This function returns the name of the current monitor profile.
        /// </summary> 
        static string GetCurrentMonitorProfile();

        /// <summary> 
        /// This function returns the name of the current wallpaper profile.
        /// </summary> 
        static string GetCurrentWallpaperProfile();

        /// <summary> 
        /// This function returns a list of all the Desktop Icon profile names.
        /// </summary> 
        static string[] GetDesktopIconsProfiles();

        /// <summary> 
        /// Gets a list of all the function names available, built-in and custom.
        /// </summary> 
        static string[] GetFunctions();

        /// <summary> 
        /// This function returns a list of all the Monitor Profile names.
        /// </summary> 
        static string[] GetMonitorProfiles();

        /// <summary> 
        /// This function returns a list of all the Wallpaper Profile names.
        /// </summary> 
        static string[] GetWallpaperProfiles();

        /// <summary> 
        /// Loads the given Desktop Icons Profile by name.
        /// </summary> 
        static bool LoadDesktopIconsProfile(string name);

        /// <summary> 
        /// Loads the given Monitor Profile by name.
        /// </summary> 
        static bool LoadMonitorProfile(string name);

        /// <summary> 
        /// Loads the given Monitor Profile by name and doesn't show any errors if it fails.
        /// </summary> 
        static bool LoadMonitorProfileHideErrors(string name);

        /// <summary> 
        /// Loads the given Wallpaper Profile by name.
        /// </summary> 
        static bool LoadWallpaperProfile(string name);

        /// <summary> 
        /// Loads the given window position profile by name.
        /// </summary> 
        static bool LoadWindowPositionProfile(string name);

        /// <summary> 
        /// Mirrors an area of the desktop starting at 100x100 with a size of 400x400. Returns the window handle for the mirror window.
        /// </summary> 
        static IntPtr MirrorSelectedArea(int x, int y, int width, int height);

        /// <summary> 
        /// This forces DisplyaFusion to reload its settings from the registry and reapply them.
        /// </summary> 
        static bool ReloadSettings();

        /// <summary> 
        /// Runs another DisplayFusion function. It can be a built-in, custom or scripted function's name.
        /// </summary> 
        static bool RunFunction(string name);

        /// <summary> 
        /// Runs another DisplayFusion function and waits for it to finish. It can be a built-in, custom or scripted function's name.
        /// </summary> 
        static bool RunFunctionAndWait(string name);

        /// <summary> 
        /// Runs another DisplayFusion function and passes the given window handle to the function. It waits for the function to finish before returning. It can be a built-in, custom or scripted function's name.
        /// </summary> 
        static bool RunFunctionAndWaitWithWindowHandle(string name, IntPtr windowHandle);

        /// <summary> 
        /// Runs another DisplayFusion function and passes the given window handle to the function. It can be a built-in, custom or scripted function's name.
        /// </summary> 
        static bool RunFunctionWithWindowHandle(string name, IntPtr windowHandle);

        /// <summary> 
        /// Saves your current desktop icon layout to the given Desktop Icons Profile name. (overwrites if exists, or creates new if needed)
        /// </summary> 
        static bool SaveDesktopIconsProfile(string name);

        /// <summary> 
        /// Saves the current window positions into a window position profile, overwriting if the profile name already exists.
        /// </summary> 
        static bool SaveWindowPositionProfile(string name);

        /// <summary> 
        /// Disables the Desktop Wallpaper feature.
        /// </summary> 
        static bool WallpaperFeatureDisable();

        /// <summary> 
        /// Enables the Desktop Wallpaper feature.
        /// </summary> 
        static bool WallpaperFeatureEnable();

        /// <summary> 
        /// Toggles the Desktop Wallpaper feature on/off.
        /// </summary> 
        static bool WallpaperFeatureToggle();

        /// <summary> 
        /// Pauses the Desktop Wallpaper Slideshow feature.
        /// </summary> 
        static bool WallpaperSlideshowPause();

        /// <summary> 
        /// Resumes the Desktop Wallpaper Slideshow feature.
        /// </summary> 
        static bool WallpaperSlideshowResume();

        /// <summary> 
        /// Toggles the Desktop Wallpaper Slideshow feature on/off.
        /// </summary> 
        static bool WallpaperSlideshowToggle();
    }
}
