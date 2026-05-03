using OWML.ModHelper;
using HarmonyLib;
using UnityEngine;

namespace owd.OuterWilds.UncapFps
{
    public class Mod : ModBehaviour
    {
        public readonly float DEFAULT_TIMESTEP = Settings.DEFAULT_TIMESTEP;
        public readonly float MIN_TIMESTEP = Settings.MIN_TIMESTEP;
        public readonly float MAX_TIMESTEP = Settings.MAX_TIMESTEP;
        private float _last;

        private void Start()
        {
            ModHelper.Console.WriteLine("Initializing UncapFps mod...");
            PluginLogger.Init(ModHelper);

            var harmony = new Harmony("owd.UncapFps");
            harmony.PatchAll();

            PluginLogger.LogInfo("Harmony initialized");
        }

        private void Update()
        {
            float dt = Time.unscaledDeltaTime;
            float clamped = Mathf.Clamp(dt, MIN_TIMESTEP, MAX_TIMESTEP);

            if (Mathf.Abs(clamped - _last) > 0.0001f)
            {
                OWTime.SetFixedTimestep(clamped);
                _last = clamped;

                // PluginLogger.LogInfo($"Updated timestep to {clamped}");
            }
        }
    }
}