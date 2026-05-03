// using HarmonyLib;
// using UnityEngine;

// namespace owd.OuterWilds.UncapFps
// {
//     [HarmonyPatch(typeof(PlayerCameraController), "UpdateRotation")]
//     class Patch_UpdateRotation
//     {
//         static bool Prefix(
//             PlayerCameraController __instance,

//             ref float ____degreesX,
//             ref float ____degreesY,
//             ref bool ____isSnapping,
//             ref Quaternion ____rotationX,
//             ref Quaternion ____rotationY,
//             ref OWCamera ____playerCamera,
//             ref ShipCockpitController ____shipController
//         )
//         {
//             if (__instance == null)
//             {
//                 return true;
//             }

//             ____degreesX %= 360f;
//             ____degreesY %= 360f;

//             if (!____isSnapping)
//             {
//                 if (____shipController != null &&
//                     ____shipController.AllowFreeLook() &&
//                     OWInput.IsPressed(InputLibrary.freeLook, 0f))
//                 {
//                     ____degreesX = Mathf.Clamp(____degreesX, -60f, 60f);
//                     ____degreesY = Mathf.Clamp(____degreesY, -35f, 80f);
//                 }
//                 else
//                 {
//                     ____degreesX = 0f;
//                     ____degreesY = Mathf.Clamp(____degreesY, -80f, 80f);

//                     if (InputUtil.IsMouseMoveAxis(InputLibrary.look.AxisID))
//                     {
//                         float axis_x = OWInput.GetAxisValue(InputLibrary.look, InputMode.All).x;

//                         // float yaw = ____playerCamera.transform.rotation.eulerAngles.y;

//                         // yaw += axis_x * (1.0f - Time.deltaTime / Settings.DEFAULT_TIMESTEP) * 3.0f;

//                         // ____playerCamera.transform.rotation = Quaternion.Euler(0f, yaw, 0f);

//                         // PluginLogger.LogInfo($"Applied yaw delta: {yaw}");
//                     }
//                 }
//             }

//             ____rotationX = Quaternion.AngleAxis(____degreesX, Vector3.up);
//             ____rotationY = Quaternion.AngleAxis(____degreesY, -Vector3.right);

//             Quaternion localRotation = ____rotationX * ____rotationY * Quaternion.identity;

//             ____playerCamera.transform.localRotation = localRotation;

//             return false;
//         }
//     }
// }