// using HarmonyLib;
// using UnityEngine;

// namespace owd.OuterWilds.UncapFps
// {
//     [HarmonyPatch(typeof(PlayerCameraController), "SnapToDegreesOverSeconds")]
//     class Patch_SnapToDegreesOverSeconds
//     {
//         static bool Prefix(
//             PlayerCameraController __instance,
//             float targetX,
//             float targetY,
//             float duration,
//             bool smoothStep,

//             ref float ____degreesX,
//             ref float ____degreesY,
//             ref float ____initSnapTime,
//             ref float ____snapDuration,
//             ref bool ____isSnapping,
//             ref bool ____smoothStepToDegrees,
//             ref float ____snapTargetX,
//             ref float ____snapTargetY,
//             ref float ____initSnapDegreesX,
//             ref float ____initSnapDegreesY
//         )
//         {
//             if(__instance == null)
//             {
//                 return true;
//             }
//             return false;
//             if (duration < Time.deltaTime)
//             {
//                 ____degreesX = targetX;
//                 ____degreesY = targetY;
//                 return false;
//             }

//             ____initSnapTime = Time.unscaledTime;
//             ____snapDuration = duration;
//             ____isSnapping = true;
//             ____smoothStepToDegrees = smoothStep;

//             ____snapTargetX = targetX;
//             ____snapTargetY = targetY;

//             ____initSnapDegreesX = ____degreesX;
//             ____initSnapDegreesY = ____degreesY;

//             return false;
//         }
//     }
// }