using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    interface Audio
    {
        static bool AdjustVolumeDown();
        static bool AdjustVolumeUp();
        static bool GetApplicationMute(uint appID);
        static float GetApplicationVolume(uint appID);
        static string GetDefaultPlaybackCommunications();
        static string GetDefaultPlaybackSounds();
        static string GetDefaultRecordingCommunications();
        static string GetDefaultRecordingSounds();
        static string[] GetPlaybackDevices();
        static string[] GetRecordingDevices();
        static bool PlayFile(string filename);
        static bool PlayWAV(string filename);
        static bool SetApplicationMute(uint appID, bool mute);
        static bool SetApplicationVolume(uint appID, float volume);
        static bool SetApplicationVolumeMax(uint appID);
        static bool SetApplicationVolumeMin(uint appID);
        static bool SetDefaultPlaybackCommunications(string name);
        static bool SetDefaultPlaybackSounds(string name);
        static bool SetDefaultRecordingCommunications(string name);
        static bool SetDefaultRecordingSounds(string name);
        static bool SetVolumeMax();
        static bool SetVolumeMin();
        static bool ToggleMute();
    }
}
