using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Taskbar
    {
        static bool IsWindowsTaskbarAutoHideEnabled();
        static bool SetWindowsTaskbarAutoHide(bool isAutoHidden);
    }
}
