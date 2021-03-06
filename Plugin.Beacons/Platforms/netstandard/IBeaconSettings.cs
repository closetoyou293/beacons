﻿using System;
using System.Collections.Generic;


namespace Plugin.Beacons
{
    public interface IBeaconSettings
    {
        IEnumerable<BeaconRegion> GetTrackingRegions();
        void StartTracking(BeaconRegion region);
        void StopTracking(BeaconRegion region);
        void StopAllTracking();
    }
}
