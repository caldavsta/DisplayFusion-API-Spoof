using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Web
    {
        /// <summary> 
        /// Returns the complete path and filename of the default web browser.
        /// </summary> 
        static string GetDefaultBrowserExe();

        /// <summary> 
        /// Opens the given Url in the default web browser.
        /// </summary> 
        static bool OpenUrl(string url);

        /// <summary> 
        /// Opens the given Url in a new default web browser window and returns the new window handle.
        /// </summary> 
        static IntPtr OpenUrlNewWindow(string url);
    }
}
