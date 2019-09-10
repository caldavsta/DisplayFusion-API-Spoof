using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface General
    {
        static string GetAppExecutable();
        static string GetAppInstallPath();
        static bool GetAppIsProVersion();
        static string GetAppVersion();
        static bool IsDesktopLocked();
        static bool LockDesktop();
        static void LogText(string text);
        static bool SleepMonitors();
        static bool ThreadWait(uint waitMS);
        static bool WakeMonitors();
    }
}
