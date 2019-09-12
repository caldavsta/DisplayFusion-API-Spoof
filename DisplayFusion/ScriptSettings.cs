using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface ScriptSettings
    {
        /// <summary> 
        /// Deletes all saved values.
        /// </summary> 
        static bool DeleteAllValues();

        /// <summary> 
        /// Deletes the value with the given name.
        /// </summary> 
        static bool DeleteValue(string name);

        /// <summary> 
        /// Gets all the value names for all ScriptSetting values.
        /// </summary> 
        static string[] GetValueNames();

        /// <summary> 
        /// Reads a setting value as a string from the given name.
        /// </summary> 
        static string ReadValue(string name);

        /// <summary> 
        /// Reads a setting value as a bool from the given name.
        /// </summary> 
        static bool ReadValueBool(string name);

        /// <summary> 
        /// Reads a setting value from the given name and decrypts it.
        /// </summary> 
        static string ReadValueEncrypted(string name);

        /// <summary> 
        /// Reads a setting value as an int from the given name.
        /// </summary> 
        static int ReadValueInt(string name);

        /// <summary> 
        /// Writes a setting value as a string to the given name.
        /// </summary> 
        static bool WriteValue(string name, string value);

        /// <summary> 
        /// Writes a setting value as a bool to the given name.
        /// </summary> 
        static bool WriteValueBool(string name, bool value);

        /// <summary> 
        /// Encrypts and writes a setting a value to the given name.
        /// </summary> 
        static bool WriteValueEncrypted(string name, string value);

        /// <summary> 
        /// Writes a setting value as ant int to the given name.
        /// </summary> 
        static bool WriteValueInt(string name, int value);
    }
}
