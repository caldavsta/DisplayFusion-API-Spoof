using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface ScreenSaver
    {
        /// <summary> 
        /// This function returns true if the screen saver requires a password.
        /// </summary> 
        static bool GetPasswordLocked();

        /// <summary> 
        /// This function gets the number of minutes before a screen saver will start (the screen saver timeout).
        /// </summary> 
        static int GetTimeoutMinutes();

        /// <summary> 
        /// This function sets whether you need to enter a screen saver after it runs.
        /// </summary> 
        static bool SetPasswordLocked(bool isPasswordLocked);

        /// <summary> 
        /// This function sets the screen saver timeout in minutes.
        /// </summary> 
        static bool SetTimeoutMinutes(int timeoutMinutes);
    }
}
