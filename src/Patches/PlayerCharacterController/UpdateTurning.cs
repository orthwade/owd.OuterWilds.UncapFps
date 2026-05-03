using HarmonyLib;

namespace owd.OuterWilds.UncapFps
{
    [HarmonyPatch(typeof(PlayerCharacterController), "UpdateTurning")]
    public static class PlayerCharacterController_UpdateTurning_Patch
    {
        static bool Prefix(PlayerCharacterController __instance)
        {
            if (__instance == null)
            {
                return true;
            }

            if (!InputUtil.IsMouseMoveAxis(InputLibrary.look.AxisID))
            {
                return true;
            }

            float coeff = Settings.DEFAULT_TIMESTEP / OWTime.GetFixedTimestep();

            PlayerCameraController.LOOK_RATE = Cached.LOOK_RATE_DEFAULT * coeff;

            return true;
        }
        static void Postfix(PlayerCharacterController __instance)
        {
            if (__instance == null)
            {
                return;
            }

            PlayerCameraController.LOOK_RATE = Cached.LOOK_RATE_DEFAULT;
        }
    }
}