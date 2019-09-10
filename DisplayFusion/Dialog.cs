using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Dialog
    {
        static bool GetUserConfirm(string message);
        static string GetUserInput(string title, string value);
        static string GetUserInputList(string title, string[] values);
        static string GetUserInputListViewWithFilter(string title, string[] values);
        static void ShowMessageError(string message);
        static void ShowMessageErrorMonospaced(string message);
        static void ShowMessageInfo(string message);
        static void ShowMessageInfoMonospaced(string message);
        static void ShowTrayMessage(string message);
    }
}
