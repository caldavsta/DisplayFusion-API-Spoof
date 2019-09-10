using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Monitor
    {
        static System.Drawing.Rectangle[] GetMonitorBounds();
        static System.Drawing.Rectangle GetMonitorBoundsByID(uint monitorID);
        static System.Drawing.Rectangle GetMonitorBoundsByMouseCursor();
        static System.Drawing.Rectangle GetMonitorBoundsByRect(Rectangle rect);
        static System.Drawing.Rectangle GetMonitorBoundsByWindow(IntPtr windowHandle);
        static System.Drawing.Rectangle GetMonitorBoundsByXY(int x, int y);
        static System.Drawing.Rectangle[] GetMonitorBoundsNoSplits();
        static int GetMonitorCountEnabled();
        static int GetMonitorCountEnabledAndDisabled();
        static int GetMonitorCountEnabledNoSplits();
        static uint GetMonitorIDByRect(Rectangle rect);
        static uint GetMonitorIDByWindow(IntPtr windowHandle);
        static uint GetMonitorIDByXY(int x, int y);
        static uint[] GetMonitorIDs();
        static System.Drawing.Rectangle GetMonitorWorkAreaByID(uint monitorID);
        static System.Drawing.Rectangle GetMonitorWorkAreaByMouseCursor();
        static System.Drawing.Rectangle GetMonitorWorkAreaByRect(Rectangle rect);
        static System.Drawing.Rectangle GetMonitorWorkAreaByWindow(IntPtr windowHandle);
        static System.Drawing.Rectangle GetMonitorWorkAreaByXY(int x, int y);
        static System.Drawing.Rectangle[] GetMonitorWorkAreas();
        static System.Drawing.Rectangle GetPrimaryMonitorBounds();
        static uint GetPrimaryMonitorID();
        static System.Drawing.Rectangle GetPrimaryMonitorWorkArea();
        static uint ShowMonitorSelector();
    }
}
