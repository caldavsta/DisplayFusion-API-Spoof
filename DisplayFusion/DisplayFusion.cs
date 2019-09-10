using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface BFS
    {
        static bool DisableAllTaskbars();
        static bool DisableTaskbar(uint monitorID);
        static bool EnableAllTaskbars();
        static bool EnableTaskbar(uint monitorID);
        static bool EnableTaskbarOnSide(uint monitorID, string side);
        static string GetCurrentMonitorProfile();
        static string GetCurrentWallpaperProfile();
        static string[] GetDesktopIconsProfiles();
        static string[] GetFunctions();
        static string[] GetMonitorProfiles();
        static string[] GetWallpaperProfiles();
        static bool LoadDesktopIconsProfile(string name);
        static bool LoadMonitorProfile(string name);
        static bool LoadMonitorProfileHideErrors(string name);
        static bool LoadWallpaperProfile(string name);
        static bool LoadWindowPositionProfile(string name);
        static IntPtr MirrorSelectedArea(int x, int y, int width, int height);
        static bool ReloadSettings();
        static bool RunFunction(string name);
        static bool RunFunctionAndWait(string name);
        static bool RunFunctionAndWaitWithWindowHandle(string name, IntPtr windowHandle);
        static bool RunFunctionWithWindowHandle(string name, IntPtr windowHandle);
        static bool SaveDesktopIconsProfile(string name);
        static bool SaveWindowPositionProfile(string name);
        static bool WallpaperFeatureDisable();
        static bool WallpaperFeatureEnable();
        static bool WallpaperFeatureToggle();
        static bool WallpaperSlideshowPause();
        static bool WallpaperSlideshowResume();
        static bool WallpaperSlideshowToggle();
    }
}
