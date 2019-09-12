using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Text
    {
        /// <summary> 
        /// Allows you to use the powerful TextQuery engine to match the given text to the given query.
        /// </summary> 
        static bool QueryIsMatch(string query, string text);

        /// <summary> 
        /// This function removes all html tags from a string, with an option to remove empty tags as well.
        /// </summary> 
        static string ScrubHtml(string text, bool isIgnorningEmptyTags);

        /// <summary> 
        /// This function removes all line breaks from a string.
        /// </summary> 
        static string ScrubLineBreaks(string text);

        /// <summary> 
        /// This function removes all line breaks from the end of a string.
        /// </summary> 
        static string ScrubLineBreaksAfter(string text);

        /// <summary> 
        /// This function removes all line breaks at the beginning of a string.
        /// </summary> 
        static string ScrubLineBreaksBefore(string text);

        /// <summary> 
        /// This function removes all tabs from a string.
        /// </summary> 
        static string ScrubTabs(string text);

        /// <summary> 
        /// This function removes all tabs from the end of a string.
        /// </summary> 
        static string ScrubTabsAfter(string text);

        /// <summary> 
        /// This function removes all tabs at the beginning of a string.
        /// </summary> 
        static string ScrubTabsBefore(string text);

        /// <summary> 
        /// This function removes all whitespace from a string.
        /// </summary> 
        static string ScrubWhitespace(string text);

        /// <summary> 
        /// This function removes all whitespace from the end of a string.
        /// </summary> 
        static string ScrubWhitespaceAfter(string text);

        /// <summary> 
        /// This function removes all whitespace at the beginning of a string.
        /// </summary> 
        static string ScrubWhitespaceBefore(string text);
    }
}
