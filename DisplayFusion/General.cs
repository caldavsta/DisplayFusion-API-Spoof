using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface General
    {
        /// <summary> 
        /// Gets the current application's executable.
        /// </summary> 
        static string GetAppExecutable();

        /// <summary> 
        /// Gets the current application's installation folder.
        /// </summary> 
        static string GetAppInstallPath();

        /// <summary> 
        /// Returns true if the application is currently the Pro Licenses version.
        /// </summary> 
        static bool GetAppIsProVersion();

        /// <summary> 
        /// Gets the current application's version.
        /// </summary> 
        static string GetAppVersion();

        /// <summary> 
        /// Returns true if the desktop is currently locked.
        /// </summary> 
        static bool IsDesktopLocked();

        /// <summary> 
        /// Locks the desktop and forces the user to login again.
        /// </summary> 
        static bool LockDesktop();

        /// <summary> 
        /// Logs a text string in your Debug log (if enabled) for troubleshooting.
        /// </summary> 
        static void LogText(string text);

        /// <summary> 
        /// Puts all of the monitors to sleep (power-saving mode).
        /// </summary> 
        static bool SleepMonitors();

        /// <summary> 
        /// Waits for 500ms before running the next lines of code.
        /// </summary> 
        static bool ThreadWait(uint waitMS);

        /// <summary> 
        /// Wakes up any sleeping (power-saving) monitors.
        /// </summary> 
        static bool WakeMonitors();
    }
}
