using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Clipboard
    {
        /// <summary> 
        /// Clears the clipboard.
        /// </summary> 
        static bool Clear();

        /// <summary> 
        /// Copies from the currently active window. (same as pressing Ctrl+C)
        /// </summary> 
        static bool Copy();

        /// <summary> 
        /// Copies from the currently active window and returns the text string that was copied.
        /// </summary> 
        static string CopyText();

        /// <summary> 
        /// Returns the text value that is currently on the clipboard.
        /// </summary> 
        static string GetText();

        /// <summary> 
        /// Returns true if the clipboard currently contains an image.
        /// </summary> 
        static bool HasImage();

        /// <summary> 
        /// Returns true if the clipboard currently contains text.
        /// </summary> 
        static bool HasText();

        /// <summary> 
        /// Pastes to the currently active window. (same as pressing Ctrl+V)
        /// </summary> 
        static bool Paste();

        /// <summary> 
        /// Pastes the given text to the current active window.
        /// </summary> 
        static bool PasteText(string text);

        /// <summary> 
        /// Sets the given html code to the clipboard.
        /// </summary> 
        static bool SetHTML(string html);

        /// <summary> 
        /// Sets the given text value to the clipboard.
        /// </summary> 
        static bool SetText(string text);
    }
}
