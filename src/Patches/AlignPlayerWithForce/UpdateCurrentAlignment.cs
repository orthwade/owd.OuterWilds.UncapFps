// using HarmonyLib;
// using UnityEngine;

// namespace owd.OuterWilds.UncapFps
// {
//     [HarmonyPatch(typeof(AlignPlayerWithForce), "UpdateCurrentAlignment")]
//     class Patch_UpdateCurrentAlignment
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