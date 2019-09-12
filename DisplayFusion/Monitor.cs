using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BFS
{
    interface Monitor
    {
        /// <summary> 
        /// Gets a list of attached monitor bounds sorted by logical monitor order from left to right.
        /// </summary> 
        static Rectangle[] GetMonitorBounds();

        /// <summary> 
        /// Gets the bounds for a specific monitor.
        /// </summary> 
        static Rectangle GetMonitorBoundsByID(uint monitorID);

        /// <summary> 
        /// Gets the bounds for the monitor where the mouse cursor is located.
        /// </summary> 
        static Rectangle GetMonitorBoundsByMouseCursor();

        /// <summary> 
        /// Gets the bounds for the monitor for the given rectangle.
        /// </summary> 
        static Rectangle GetMonitorBoundsByRect(Rectangle rect);

        /// <summary> 
        /// Gets the bounds of the monitor where the window is located.
        /// </summary> 
        static Rectangle GetMonitorBoundsByWindow(IntPtr windowHandle);

        /// <summary> 
        /// Gets the bounds of the monitor that contains the given coordinates.
        /// </summary> 
        static Rectangle GetMonitorBoundsByXY(int x, int y);

        /// <summary> 
        /// Gets a list of attached monitor bounds sorted by logical monitor order from left to right, ignores any monitor splits that you may have configured.
        /// </summary> 
        static Rectangle[] GetMonitorBoundsNoSplits();

        /// <summary> 
        /// Gets a count of the number of attached monitors, including splits.
        /// </summary> 
        static int GetMonitorCountEnabled();

        /// <summary> 
        /// Gets a count of the number of attached or disconnected monitors.
        /// </summary> 
        static int GetMonitorCountEnabledAndDisabled();

        /// <summary> 
        /// Gets a count of the number of attached monitors, excluding splits.
        /// </summary> 
        static int GetMonitorCountEnabledNoSplits();

        /// <summary> 
        /// Gets the ID of the monitor for the given rectangle.
        /// </summary> 
        static uint GetMonitorIDByRect(Rectangle rect);

        /// <summary> 
        /// Gets the ID of the monitor where the window is located.
        /// </summary> 
        static uint GetMonitorIDByWindow(IntPtr windowHandle);

        /// <summary> 
        /// Gets the ID of the monitor that contains the given coordinates.
        /// </summary> 
        static uint GetMonitorIDByXY(int x, int y);

        /// <summary> 
        /// Gets a list of attached monitor IDs sorted by logical monitor order from left to right.
        /// </summary> 
        static uint[] GetMonitorIDs();

        /// <summary> 
        /// Gets the work area for a specific monitor.
        /// </summary> 
        static Rectangle GetMonitorWorkAreaByID(uint monitorID);

        /// <summary> 
        /// Gets the work area for the monitor where the mouse cursor is located.
        /// </summary> 
        static Rectangle GetMonitorWorkAreaByMouseCursor();

        /// <summary> 
        /// Gets the work area for the monitor for the given rectangle.
        /// </summary> 
        static Rectangle GetMonitorWorkAreaByRect(Rectangle rect);

        /// <summary> 
        /// Gets the work area of the monitor where the window is located.
        /// </summary> 
        static Rectangle GetMonitorWorkAreaByWindow(IntPtr windowHandle);

        /// <summary> 
        /// Gets the work area of the monitor that contains the given coordinates.
        /// </summary> 
        static Rectangle GetMonitorWorkAreaByXY(int x, int y);

        /// <summary> 
        /// Gets a list of attached monitor workareas sorted by logical monitor order from left to right.
        /// </summary> 
        static Rectangle[] GetMonitorWorkAreas();

        /// <summary> 
        /// Gets the bounds of the primary monitor.
        /// </summary> 
        static Rectangle GetPrimaryMonitorBounds();

        /// <summary> 
        /// Gets the ID of the primary monitor.
        /// </summary> 
        static uint GetPrimaryMonitorID();

        /// <summary> 
        /// Gets the work area of the primary monitor.
        /// </summary> 
        static Rectangle GetPrimaryMonitorWorkArea();

        /// <summary> 
        /// Allows the user to select a monitor from a dialog and returns the monitorID or returns 0 if they cancel.
        /// </summary> 
        static uint ShowMonitorSelector();
    }
}
