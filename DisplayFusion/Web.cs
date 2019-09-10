using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Web
    {
        static string GetDefaultBrowserExe();
        static bool OpenUrl(string url);
        static IntPtr OpenUrlNewWindow(string url);
    }
}
