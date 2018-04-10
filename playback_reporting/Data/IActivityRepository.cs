﻿using System;
using System.Collections.Generic;
using playback_reporting.Api;
using MediaBrowser.Model.Querying;

namespace playback_reporting.Data
{
    public interface IActivityRepository
    {
        void AddPlaybackAction(PlaybackInfo play_info);
        List<Dictionary<string, string>> GetUsageForUser(string date, string user_id, string[] filter);
        Dictionary<String, Dictionary<string, int>> GetUsageForDays(int numberOfDays, string[] types, string data_type);
    }
}