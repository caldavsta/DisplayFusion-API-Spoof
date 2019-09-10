using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Input
    {
        static int GetMousePositionX();
        static int GetMousePositionY();
        static bool IsKeyDown(string keys);
        static bool IsMouseDown(string buttons);
        static bool LeftClickMouse();
        static bool MiddleClickMouse();
        static bool RightClickMouse();
        static bool SendKeyDown(string keys);
        static bool SendKeys(string keys);
        static bool SendKeysFast(string keys);
        static bool SendKeyUp(string keys);
        static bool SendText(string text);
        static bool SetMousePosition(int x, int y);
        static bool SetMousePositionRelative(int x, int y);
        static bool SetMousePositionRelativeNoAcceleration(int x, int y);
    }
}
