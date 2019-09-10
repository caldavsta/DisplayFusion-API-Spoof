using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface ScreenSaver
    {
        static bool GetPasswordLocked();
        static int GetTimeoutMinutes();
        static bool SetPasswordLocked(bool isPasswordLocked);
        static bool SetTimeoutMinutes(int timeoutMinutes);
    }
}
