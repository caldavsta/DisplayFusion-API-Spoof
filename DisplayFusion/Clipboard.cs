using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Clipboard
    {
        static bool Clear();
        static bool Copy();
        static string CopyText();
        static string GetText();
        static bool HasImage();
        static bool HasText();
        static bool Paste();
        static bool PasteText(string text);
        static bool SetHTML(string html);
        static bool SetText(string text);
    }
}
