using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace BFS
{
    interface Window
    {
        /// <summary> 
        /// This function adds the given window handle to the Windows taskbar as a taskbar item.
        /// </summary> 
        static bool AddToWindowsTaskbar(IntPtr windowHandle);

        /// <summary> 
        /// Builds a helpful string of debug information aboout the given window handle.
        /// </summary> 
        static string BuildWindowDebug(IntPtr windowHandle);

        /// <summary> 
        /// Close the given window handle (kills the window).
        /// </summary> 
        static bool Close(IntPtr windowHandle);

        /// <summary> 
        /// Disables the given window, this prevents the window from receiving input. Same as the WS_DISABLED style.
        /// </summary> 
        static bool DisableWindow(IntPtr windowHandle);

        /// <summary> 
        /// Enables the given window handle.
        /// </summary> 
        static bool EnableWindow(IntPtr windowHandle);

        /// <summary> 
        /// Focus the given window handle (make it the top window).
        /// </summary> 
        static bool Focus(IntPtr windowHandle);

        /// <summary> 
        /// Gets an array of all the window handles for all applications.
        /// </summary> 
        static IntPtr[] GetAllWindowHandles();

        /// <summary> 
        /// Returns true if the given window is always on top.
        /// </summary> 
        static bool GetAlwaysOnTop(IntPtr windowHandle);

        /// <summary> 
        /// Returns the window's bounds for the given window handle.
        /// </summary> 
        static Rectangle GetBounds(IntPtr windowHandle);

        /// <summary> 
        /// Gets the direct child window handle for a given parent window, by searching for the given class name.
        /// </summary> 
        static IntPtr GetChildWindowByClass(IntPtr windowHandleParent, string windowClass);

        /// <summary> 
        /// Gets the given window handle's window class name.
        /// </summary> 
        static string GetClass(IntPtr windowHandle);

        /// <summary> 
        /// Returns the client area size (the area inside the window border) for the given window handle.
        /// </summary> 
        static Rectangle GetClientRect(IntPtr windowHandle);

        /// <summary> 
        /// Gets the currently focused window (the foreground window).
        /// </summary> 
        static IntPtr GetFocusedWindow();

        /// <summary> 
        /// Returns the owner window's handle for the given window handle, if the given window handle has an owner.
        /// </summary> 
        static IntPtr GetOwner(IntPtr windowHandle);

        /// <summary> 
        /// Returns the parent window's handle for the given window handle.
        /// </summary> 
        static IntPtr GetParent(IntPtr windowHandle);

        /// <summary> 
        /// Returns the root parent window's handle for the given window handle.
        /// </summary> 
        static IntPtr GetParentRoot(IntPtr windowHandle);

        /// <summary> 
        /// Gets the given window handle's title text.
        /// </summary> 
        static string GetText(IntPtr windowHandle);

        /// <summary> 
        /// Gets the given windows transparency percent, between 0% and 100%.
        /// </summary> 
        static decimal GetTransparency(IntPtr windowHandle);

        /// <summary> 
        /// Gets an array of all the visible window handles for all applications including windows that are minimized.
        /// </summary> 
        static IntPtr[] GetVisibleAndMinimizedWindowHandles();

        /// <summary> 
        /// Gets an array of all the visible window handles for all applications excluding windows that are minimized.
        /// </summary> 
        static IntPtr[] GetVisibleWindowHandles();

        /// <summary> 
        /// Returns an array of visible window handles for the given monitorID. In this example, the visible windows on monitor #2 are returned.
        /// </summary> 
        static IntPtr[] GetVisibleWindowHandlesByMonitor(uint monitorID);

        /// <summary> 
        /// Searches through all desktop windows and returns the first one it finds with the given window class.
        /// </summary> 
        static IntPtr GetWindowByClass(string windowClass);

        /// <summary> 
        /// Searches through all desktop windows and returns the first one it finds with the given window text. This method supports wildcards, like "*ends" or "*title*".
        /// </summary> 
        static IntPtr GetWindowByText(string windowText);

        /// <summary> 
        /// Searches through all desktop windows and returns the first one it finds with the given window text. This method does not support wildcards.
        /// </summary> 
        static IntPtr GetWindowByTextExact(string windowText);

        /// <summary> 
        /// Gets the IntPtr value associated with the given window handle and window property name.
        /// </summary> 
        static IntPtr GetWindowProperty(IntPtr windowHandle, string propertyName);

        /// <summary> 
        /// Searches through all desktop windows and returns a list of windows that match the given window text. This method supports wildcards, like "*ends" or "*title*".
        /// </summary> 
        static IntPtr[] GetWindowsByText(string windowText);

        /// <summary> 
        /// Searches through all desktop windows and returns a list of windows that match the given window text. This method does not support wildcards.
        /// </summary> 
        static IntPtr[] GetWindowsByTextExact(string windowText);

        /// <summary> 
        /// Gets the window style for a given window.
        /// </summary> 
        static BFS.WindowEnum.WindowStyle GetWindowStyle(IntPtr windowHandle);

        /// <summary> 
        /// Gets the extended window style for a given window.
        /// </summary> 
        static BFS.WindowEnum.WindowStyleEx GetWindowStyleEx(IntPtr windowHandle);

        /// <summary> 
        /// Gets the window handle for the window under the mouse cursor, or the desktop window handle if the cursor is over the desktop.
        /// </summary> 
        static IntPtr GetWindowUnderMouse();

        /// <summary> 
        /// Checks if the given window has a certain style set.
        /// </summary> 
        static bool HasWindowStyle(BFS.WindowEnum.WindowStyle windowStyle, IntPtr windowHandle);

        /// <summary> 
        /// Checks if the given window has a certain extended style set.
        /// </summary> 
        static bool HasWindowStyleEx(BFS.WindowEnum.WindowStyleEx windowStyleEx, IntPtr windowHandle);

        /// <summary> 
        /// Returns true if the given window handle is hung (not responding).
        /// </summary> 
        static bool IsHung(IntPtr windowHandle);

        /// <summary> 
        /// Returns true if the given window handle is maximized.
        /// </summary> 
        static bool IsMaximized(IntPtr windowHandle);

        /// <summary> 
        /// Returns true if the given window handle is minimized.
        /// </summary> 
        static bool IsMinimized(IntPtr windowHandle);

        /// <summary> 
        /// Returns true if the given window handle is restored (not minimized or maximized).
        /// </summary> 
        static bool IsRestored(IntPtr windowHandle);

        /// <summary> 
        /// Returns true if the given window handle is visible.
        /// </summary> 
        static bool IsVisible(IntPtr windowHandle);

        /// <summary> 
        /// Returns true if the given window handle is currently rolled up to a hat.
        /// </summary> 
        static bool IsWindowRolledUpToHat(IntPtr windowHandle);

        /// <summary> 
        /// Returns true if the given window handle is currently rolled up to an icon.
        /// </summary> 
        static bool IsWindowRolledUpToIcon(IntPtr windowHandle);

        /// <summary> 
        /// Returns true if the given window handle is currently rolled up to the TitleBar only.
        /// </summary> 
        static bool IsWindowRolledUpToTitleBar(IntPtr windowHandle);

        /// <summary> 
        /// Maximizes the given window handle.
        /// </summary> 
        static bool Maximize(IntPtr windowHandle);

        /// <summary> 
        /// Minimizes the given window handle.
        /// </summary> 
        static bool Minimize(IntPtr windowHandle);

        /// <summary> 
        /// Move and resize the window to the bottom half of its current monitor.
        /// </summary> 
        static bool MoveToBottomMonitorHalf(IntPtr windowHandle);

        /// <summary> 
        /// Move the window to the centre of its current monitor.
        /// </summary> 
        static bool MoveToCentreMonitor(IntPtr windowHandle);

        /// <summary> 
        /// Move and resize the window to the left half its current monitor.
        /// </summary> 
        static bool MoveToLeftMonitorHalf(IntPtr windowHandle);

        /// <summary> 
        /// Move the window to a specific monitor.
        /// </summary> 
        static bool MoveToMonitor(uint monitorID, IntPtr windowHandle);

        /// <summary> 
        /// Move the window to a specific monitor and maximize it.
        /// </summary> 
        static bool MoveToMonitorMaximized(uint monitorID, IntPtr windowHandle);

        /// <summary> 
        /// Move the window the a specific monitor and resize it proportional to the new monitor.
        /// </summary> 
        static bool MoveToMonitorResized(uint monitorID, IntPtr windowHandle);

        /// <summary> 
        /// Move the window to the next monitor to the right.
        /// </summary> 
        static bool MoveToNextMonitor(IntPtr windowHandle);

        /// <summary> 
        /// Move the window to the next monitor to the right and maximize it.
        /// </summary> 
        static bool MoveToNextMonitorMaximized(IntPtr windowHandle);

        /// <summary> 
        /// Move the window to the next monitor to the right and resize it proportional to the new monitor.
        /// </summary> 
        static bool MoveToNextMonitorResized(IntPtr windowHandle);

        /// <summary> 
        /// Move the window to the next monitor to the left.
        /// </summary> 
        static bool MoveToPreviousMonitor(IntPtr windowHandle);

        /// <summary> 
        /// Move the window to the next monitor to the left and maximize it.
        /// </summary> 
        static bool MoveToPreviousMonitorMaximized(IntPtr windowHandle);

        /// <summary> 
        /// Move the window to the next monitor to the left and resize it proportional to the new monitor.
        /// </summary> 
        static bool MoveToPreviousMonitorResized(IntPtr windowHandle);

        /// <summary> 
        /// Move and resize the window to the right half of its current monitor.
        /// </summary> 
        static bool MoveToRightMonitorHalf(IntPtr windowHandle);

        /// <summary> 
        /// Move and resize the window to the top half of its current monitor.
        /// </summary> 
        static bool MoveToTopMonitorHalf(IntPtr windowHandle);

        /// <summary> 
        /// This function removes the given window handle from the Windows taskbar.
        /// </summary> 
        static bool RemoveFromWindowsTaskbar(IntPtr windowHandle);

        /// <summary> 
        /// This function will remove any window highlighting, if it is enabled for this window.
        /// </summary> 
        static bool RemoveWindowHighlight(IntPtr windowHandle);

        /// <summary> 
        /// Removes the given window property name from the given window handle.
        /// </summary> 
        static bool RemoveWindowProperty(IntPtr windowHandle, string propertyName);

        /// <summary> 
        /// Restores the given window handle.
        /// </summary> 
        static bool Restore(IntPtr windowHandle);

        /// <summary> 
        /// Rollup the given window handle to a hat.
        /// </summary> 
        static bool RollupWindowToHat(IntPtr windowHandle);

        /// <summary> 
        /// Rollup the given window handle to an icon.
        /// </summary> 
        static bool RollupWindowToIcon(IntPtr windowHandle);

        /// <summary> 
        /// Rollup the given window handle to only the TitleBar.
        /// </summary> 
        static bool RollupWindowToTitleBar(IntPtr windowHandle);

        /// <summary> 
        /// Sets the given window to always on top or not on top.
        /// </summary> 
        static bool SetAlwaysOnTop(IntPtr windowHandle, bool alwaysOnTop);

        /// <summary> 
        /// Moves the given window to 200x300.
        /// </summary> 
        static bool SetLocation(IntPtr windowHandle, int x, int y);

        /// <summary> 
        /// Sets the given window handle's owner to WindowHandleOwner.
        /// </summary> 
        static bool SetOwner(IntPtr windowHandle, IntPtr windowHandleOwner);

        /// <summary> 
        /// Resizes the given window to 800x600.
        /// </summary> 
        static bool SetSize(IntPtr windowHandle, int width, int height);

        /// <summary> 
        /// Resizes the given window to 800x600 and moves it to 200x300.
        /// </summary> 
        static bool SetSizeAndLocation(IntPtr windowHandle, int x, int y, int width, int height);

        /// <summary> 
        /// Sets the given window handle's title text.
        /// </summary> 
        static bool SetText(IntPtr windowHandle, string text);

        /// <summary> 
        /// Sets the given windows transparency to 50%. Use values between 0 and 100 for the percent.
        /// </summary> 
        static bool SetTransparency(IntPtr windowHandle, decimal transparencyPercent);

        /// <summary> 
        /// This function will highlight the given window's border user the colour provided. If you pass Color.Transparent a colour picker dialog will be shown.
        /// </summary> 
        static bool SetWindowHighlight(IntPtr windowHandle, Color colour);

        /// <summary> 
        /// Sets the given window property value.
        /// </summary> 
        static bool SetWindowProperty(IntPtr windowHandle, string propertyName, IntPtr propertyValue);

        /// <summary> 
        /// Sets the given window to the given style.
        /// </summary> 
        static bool SetWindowStyle(BFS.WindowEnum.WindowStyle windowStyle, IntPtr windowHandle);

        /// <summary> 
        /// Sets the given window to the given extended style.
        /// </summary> 
        static bool SetWindowStyleEx(BFS.WindowEnum.WindowStyleEx windowStyleEx, IntPtr windowHandle);

        /// <summary> 
        /// Hides all windows and shows the desktop. (same as pressing Win+D)
        /// </summary> 
        static bool ShowDesktop(IntPtr windowHandle);

        /// <summary> 
        /// Toggles the given window between always on top and not on top.
        /// </summary> 
        static bool ToggleAlwaysOnTop(IntPtr windowHandle);

        /// <summary> 
        /// Unroll the given window handle if it is currently rolled-up as a hat.
        /// </summary> 
        static bool UnrollWindowFromHat(IntPtr windowHandle);

        /// <summary> 
        /// Unroll the given window handle if it is currently rolled-up as an icon.
        /// </summary> 
        static bool UnrollWindowFromIcon(IntPtr windowHandle);

        /// <summary> 
        /// Unroll the given window handle if it is currently rolled-up to the TitleBar only.
        /// </summary> 
        static bool UnrollWindowFromTitleBar(IntPtr windowHandle);
    }
}
