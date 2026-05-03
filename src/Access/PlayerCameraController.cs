using HarmonyLib;
using UnityEngine;

namespace owd.OuterWilds.UncapFps.Acces
{
    public static class PlayerCameraController_Access
    {
        // Access to private method private void UpdateInput(float deltaTime)
        public static void UpdateInput(this PlayerCameraController controller, float deltaTime)
        {
            var method = AccessTools.Method(typeof(PlayerCameraController), "UpdateInput");
            if (method != null)
            {
                method.Invoke(controller, new object[] { deltaTime });
            }
            else
            {
                PluginLogger.LogError("Failed to access UpdateInput method.");
            }
        }
        
    }
}