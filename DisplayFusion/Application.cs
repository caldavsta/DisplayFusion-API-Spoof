using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Application
    {
        static string[] GetAllRunningApplicationFiles();
        static uint[] GetAllRunningApplicationIDs();
        static uint GetAppIDByFile(string file);
        static uint GetAppIDByWindow(IntPtr windowHandle);
        static string GetMainFileByAppID(uint appID);
        static string GetMainFileByWildcard(string file);
        static string GetMainFileByWindow(IntPtr windowHandle);
        static IntPtr GetMainWindowByAppID(uint appID);
        static IntPtr GetMainWindowByFile(string file);
        static bool IsAppRunningByAppID(uint appID);
        static bool IsAppRunningByFile(string file);
        static bool Kill(uint appID);
        static uint Start(string filename, string arguments);
        static bool WaitForExitByAppID(uint appID, uint waitMS);
        static bool WaitForExitByFile(uint appID, uint waitMS);
    }
}
