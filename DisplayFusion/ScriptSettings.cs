using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface ScriptSettings
    {
        static bool DeleteAllValues();
        static bool DeleteValue(string name);
        static string[] GetValueNames();
        static string ReadValue(string name);
        static bool ReadValueBool(string name);
        static string ReadValueEncrypted(string name);
        static int ReadValueInt(string name);
        static bool WriteValue(string name, string value);
        static bool WriteValueBool(string name, bool value);
        static bool WriteValueEncrypted(string name, string value);
        static bool WriteValueInt(string name, int value);
    }
}
