﻿using BepInEx;

namespace SliderUnlocker
{
    [BepInPlugin(GUID, PluginName, Version)]
    public partial class SliderUnlocker : BaseUnityPlugin
    {
        private void Main() => VoicePitchUnlocker.Init();
    }
}