using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Dialog
    {
        /// <summary> 
        /// Shows a Yes/No prompt to the user, and returns True/False depending on what they select.
        /// </summary> 
        static bool GetUserConfirm(string message);

        /// <summary> 
        /// Shows an input dialog to the user where they can type anything they want. You can provide a preset value.
        /// </summary> 
        static string GetUserInput(string title, string value);

        /// <summary> 
        /// Shows a list of given items in a dropdown list and returns the selected string. Returns an empty string if the user clicks "Cancel".
        /// </summary> 
        static string GetUserInputList(string title, string[] values);

        /// <summary> 
        /// Shows a list of given items in a listview with a filter box, and returns the selected string. Returns an empty string if the user clicks "Cancel".
        /// </summary> 
        static string GetUserInputListViewWithFilter(string title, string[] values);

        /// <summary> 
        /// Shows an error messagebox to the user with an OK button.
        /// </summary> 
        static void ShowMessageError(string message);

        /// <summary> 
        /// Shows an error messagebox to the user with an OK button in a Monospaced font.
        /// </summary> 
        static void ShowMessageErrorMonospaced(string message);

        /// <summary> 
        /// Shows a messagebox to the user with an OK button.
        /// </summary> 
        static void ShowMessageInfo(string message);

        /// <summary> 
        /// Shows a messagebox to the user with an OK button using a Monospaced font.
        /// </summary> 
        static void ShowMessageInfoMonospaced(string message);

        /// <summary> 
        /// Shows a tray balloon or toast message.
        /// </summary> 
        static void ShowTrayMessage(string message);
    }
}
