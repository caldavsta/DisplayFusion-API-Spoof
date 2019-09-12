using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Input
    {
        /// <summary> 
        /// Gets the mouse X position on the screen.
        /// </summary> 
        static int GetMousePositionX();

        /// <summary> 
        /// Gets the mouse Y position on the screen.
        /// </summary> 
        static int GetMousePositionY();

        /// <summary> 
        /// Returns true if the Virtual Key Codes (VK) are down. Separate multiple codes with ; and the function will only return true if all the keys are pressed at once.
        /// </summary> 
        static bool IsKeyDown(string keys);

        /// <summary> 
        /// Returns true if the Virtual Key Codes (VK) are down. Separate multiple codes with ; and the function will only return true if all the keys and mouse buttons are pressed at once.
        /// </summary> 
        static bool IsMouseDown(string buttons);

        /// <summary> 
        /// Simulates a mouse left-click at the current mouse position.
        /// </summary> 
        static bool LeftClickMouse();

        /// <summary> 
        /// Simulates a mouse middle-click at the current mouse position.
        /// </summary> 
        static bool MiddleClickMouse();

        /// <summary> 
        /// Simulates a mouse right-click at the current mouse position.
        /// </summary> 
        static bool RightClickMouse();

        /// <summary> 
        /// Presses a key down without releasing it. This is the same as pressing and holding a key.
        /// </summary> 
        static bool SendKeyDown(string keys);

        /// <summary> 
        /// Simulates key presses, with or without modifiers (Alt, Ctrl, Shift, Win).
        /// </summary> 
        static bool SendKeys(string keys);

        /// <summary> 
        /// The same as SendKeys but uses a lower delay for the keypress duration. This may cause compatibility issues with some applications.
        /// </summary> 
        static bool SendKeysFast(string keys);

        /// <summary> 
        /// Releases a key that was previously pressed.
        /// </summary> 
        static bool SendKeyUp(string keys);

        /// <summary> 
        /// This function types the given text string, as if it was being typed by a user.
        /// </summary> 
        static bool SendText(string text);

        /// <summary> 
        /// Moves the mouse cursor to a specific location on the screen.
        /// </summary> 
        static bool SetMousePosition(int x, int y);

        /// <summary> 
        /// Moves the mouse cursor relatively from the current position on the screen and generates WM_MouseMove messages.
        /// </summary> 
        static bool SetMousePositionRelative(int x, int y);

        /// <summary> 
        /// Moves the mouse cursor relatively from the current position on the screen without any DPI acceleration, and doesn't generate WM_MouseMove messages.
        /// </summary> 
        static bool SetMousePositionRelativeNoAcceleration(int x, int y);
    }
}
