using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Text
    {
        static bool QueryIsMatch(string query, string text);
        static string ScrubHtml(string text, bool isIgnorningEmptyTags);
        static string ScrubLineBreaks(string text);
        static string ScrubLineBreaksAfter(string text);
        static string ScrubLineBreaksBefore(string text);
        static string ScrubTabs(string text);
        static string ScrubTabsAfter(string text);
        static string ScrubTabsBefore(string text);
        static string ScrubWhitespace(string text);
        static string ScrubWhitespaceAfter(string text);
        static string ScrubWhitespaceBefore(string text);
    }
}
