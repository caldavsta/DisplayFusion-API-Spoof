using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Taskbar
    {
        /// <summary> 
        /// This function returns true if the Windows taskbar is currently set to auto-hide.
        /// </summary> 
        static bool IsWindowsTaskbarAutoHideEnabled();

        /// <summary> 
        /// This function allows you to enable or disable the Windows taskbar auto-hide.
        /// </summary> 
        static bool SetWindowsTaskbarAutoHide(bool isAutoHidden);
    }
}
