// using HarmonyLib;
// using UnityEngine;

// namespace owd.OuterWilds.UncapFps
// {
//     [HarmonyPatch(typeof(PlayerCameraController), "AddDegreesY")]
//     class Patch_AddDegreesY
//     {
//         static bool Prefix(
//             PlayerCameraController __instance,

//             ref float ____degreesY
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