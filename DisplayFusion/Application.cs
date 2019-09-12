using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Application
    {
        /// <summary> 
        /// Gets a list of filenames of all running processes that DisplayFusion has access to see.
        /// </summary> 
        static string[] GetAllRunningApplicationFiles();

        /// <summary> 
        /// Gets a list of all running appIDs (processIDs) that DisplayFusion has access to see.
        /// </summary> 
        static uint[] GetAllRunningApplicationIDs();

        /// <summary> 
        /// Gets the appID (processID) of the given file, if that file is running.
        /// </summary> 
        static uint GetAppIDByFile(string file);

        /// <summary> 
        /// Gets the appID (processID) of the given window.
        /// </summary> 
        static uint GetAppIDByWindow(IntPtr windowHandle);

        /// <summary> 
        /// This function returns the main filename from the given App ID.
        /// </summary> 
        static string GetMainFileByAppID(uint appID);

        /// <summary> 
        /// Returns the full path for the given wildcard for a running process.
        /// </summary> 
        static string GetMainFileByWildcard(string file);

        /// <summary> 
        /// This function returns the main filename from the given window handle.
        /// </summary> 
        static string GetMainFileByWindow(IntPtr windowHandle);

        /// <summary> 
        /// Returns the main window handle for the given appID (ProcessID).
        /// </summary> 
        static IntPtr GetMainWindowByAppID(uint appID);

        /// <summary> 
        /// Returns the main window handle for the given absolute filename or wildcard.
        /// </summary> 
        static IntPtr GetMainWindowByFile(string file);

        /// <summary> 
        /// Checks if the given appID (ProcessID) is running.
        /// </summary> 
        static bool IsAppRunningByAppID(uint appID);

        /// <summary> 
        /// Checks if the given absolute filename or wildcard is running.
        /// </summary> 
        static bool IsAppRunningByFile(string file);

        /// <summary> 
        /// Terminates the given appID (ProcessID).
        /// </summary> 
        static bool Kill(uint appID);

        /// <summary> 
        /// Starts the given application using the command line parameters (optional).
        /// </summary> 
        static uint Start(string filename, string arguments);

        /// <summary> 
        /// Waits for the given appID (ProcessID) to exit, stops waiting after 5000ms (5 seconds). Pass 0 for waitMS to wait forever until it exits.
        /// </summary> 
        static bool WaitForExitByAppID(uint appID, uint waitMS);

        /// <summary> 
        /// Waits for the given absolute filename or wildcard to exit, stops waiting after 5000ms (5 seconds). Pass 0 for waitMS to wait forever until it exits.
        /// </summary> 
        static bool WaitForExitByFile(uint appID, uint waitMS);
    }
}
