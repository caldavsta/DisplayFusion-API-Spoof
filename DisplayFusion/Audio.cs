using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Audio
    {
        /// <summary> 
        /// Adjusts the master volume down one tick.
        /// </summary> 
        static bool AdjustVolumeDown();

        /// <summary> 
        /// Adjusts the master volume up one tick.
        /// </summary> 
        static bool AdjustVolumeUp();

        /// <summary> 
        /// Gets whether or not an application is muted from its process ID.
        /// </summary> 
        static bool GetApplicationMute(uint appID);

        /// <summary> 
        /// Gets the volume of an application by its process ID. The returned value will be between 0 and 1.
        /// </summary> 
        static float GetApplicationVolume(uint appID);

        /// <summary> 
        /// Gets the name of the default playback device for communications.
        /// </summary> 
        static string GetDefaultPlaybackCommunications();

        /// <summary> 
        /// Gets the name of the default playback device for sounds.
        /// </summary> 
        static string GetDefaultPlaybackSounds();

        /// <summary> 
        /// Gets the name of the default recording device for communications.
        /// </summary> 
        static string GetDefaultRecordingCommunications();

        /// <summary> 
        /// Gets the name of the default recording device for sounds.
        /// </summary> 
        static string GetDefaultRecordingSounds();

        /// <summary> 
        /// Gets a list of all the enabled playback devices.
        /// </summary> 
        static string[] GetPlaybackDevices();

        /// <summary> 
        /// Gets a list of all the enabled recording devices.
        /// </summary> 
        static string[] GetRecordingDevices();

        /// <summary> 
        /// This function allows you to play an audio file (wav, mp3... etc).
        /// </summary> 
        static bool PlayFile(string filename);

        /// <summary> 
        /// This function allows you to play a .wav file.
        /// </summary> 
        static bool PlayWAV(string filename);

        /// <summary> 
        /// Sets mute on an application by its process ID.
        /// </summary> 
        static bool SetApplicationMute(uint appID, bool mute);

        /// <summary> 
        /// Sets the volume of an application by its process ID. Accepts values between 0 and 1.
        /// </summary> 
        static bool SetApplicationVolume(uint appID, float volume);

        /// <summary> 
        /// Raises the volume of an application to its maximum value by process ID.
        /// </summary> 
        static bool SetApplicationVolumeMax(uint appID);

        /// <summary> 
        /// Lowers the volume of an application to its minimum value by process ID.
        /// </summary> 
        static bool SetApplicationVolumeMin(uint appID);

        /// <summary> 
        /// Sets the default playback device for communications (like Skype).
        /// </summary> 
        static bool SetDefaultPlaybackCommunications(string name);

        /// <summary> 
        /// Sets the default playback device for sounds, music and applications.
        /// </summary> 
        static bool SetDefaultPlaybackSounds(string name);

        /// <summary> 
        /// Sets the default recording device for communications (like Skype).
        /// </summary> 
        static bool SetDefaultRecordingCommunications(string name);

        /// <summary> 
        /// Sets the default recording device for sounds, music and applications.
        /// </summary> 
        static bool SetDefaultRecordingSounds(string name);

        /// <summary> 
        /// Sets the master volume to maximum.
        /// </summary> 
        static bool SetVolumeMax();

        /// <summary> 
        /// Sets the master volume to 0.
        /// </summary> 
        static bool SetVolumeMin();

        /// <summary> 
        /// Toggles the master volume mute on/off.
        /// </summary> 
        static bool ToggleMute();
    }
}
