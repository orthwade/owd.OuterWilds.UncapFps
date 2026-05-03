// using HarmonyLib;
// using UnityEngine;

// namespace owd.OuterWilds.UncapFps
// {
//     [HarmonyPatch(typeof(PlayerCameraController), "FixedUpdate")]
//     class Patch_FixedUpdate
//     {
//         static bool Prefix(
//             PlayerCameraController __instance
//         )
//         {
//             if(__instance == null)
//             {
//                 return true;
//             }
//             return false;

//             return false;
//         }
//     }
// }