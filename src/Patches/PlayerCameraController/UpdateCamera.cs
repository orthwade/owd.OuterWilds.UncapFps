// using HarmonyLib;
// using owd.OuterWilds.UncapFps.Acces;
// using UnityEngine;

// namespace owd.OuterWilds.UncapFps
// {
//     [HarmonyPatch(typeof(PlayerCameraController), "UpdateCamera")]
//     class Patch_UpdateCamera
//     {
//         static System.Reflection.MethodInfo _updateInput;
//         static System.Reflection.MethodInfo _updateLockOn;
//         static System.Reflection.MethodInfo _updateFOV;
//         static System.Reflection.MethodInfo _updateRotation;

//         static void Init()
//         {
//             var t = typeof(PlayerCameraController);

//             _updateInput = t.GetMethod("UpdateInput", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
//             _updateLockOn = t.GetMethod("UpdateLockOnTargeting", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
//             _updateFOV = t.GetMethod("UpdateFieldOfView", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
//             _updateRotation = t.GetMethod("UpdateRotation", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
//         }

//         static bool Prefix(
//             PlayerCameraController __instance,
//             float deltaTime,

//             ref bool ____isLockedOn,
//             ref bool ____isSnapping,
//             ref bool ____smoothStepToDegrees,
//             ref float ____initSnapTime,
//             ref float ____snapDuration,
//             ref float ____degreesX,
//             ref float ____degreesY,
//             ref float ____initSnapDegreesX,
//             ref float ____initSnapDegreesY,
//             ref float ____snapTargetX,
//             ref float ____snapTargetY,

//             ref PlayerCharacterController ____characterController,
//             ref Vector3 ____origLocalPosition,
//             ref Vector3 ____targetLocalPosition
//         )
//         {
//             if(__instance == null)
//             {
//                 return true;
//             }
//             if (_updateInput == null) Init();

//             _updateInput.Invoke(__instance, new object[] { deltaTime });

//             if (____isLockedOn)
//             {
//                 _updateLockOn.Invoke(__instance, new object[] { deltaTime });
//             }

//             if (____isSnapping && !____isLockedOn)
//             {
//                 float num = Mathf.InverseLerp(
//                     ____initSnapTime,
//                     ____initSnapTime + ____snapDuration,
//                     Time.unscaledTime);

//                 if (____smoothStepToDegrees)
//                 {
//                     num = Mathf.SmoothStep(0f, 1f, num);
//                 }

//                 if (num >= 1f)
//                 {
//                     ____isSnapping = false;
//                 }

//                 ____degreesX = Mathf.Lerp(____initSnapDegreesX, ____snapTargetX, num);
//                 ____degreesY = Mathf.Lerp(____initSnapDegreesY, ____snapTargetY, num);
//             }

//             float t = (____characterController.GetJumpCrouchFraction() > 0f) ? 1f : 0.1f;

//             ____targetLocalPosition =
//                 ____origLocalPosition -
//                 Vector3.up * 0.3f * ____characterController.GetJumpCrouchFraction();

//             __instance.transform.localPosition =
//                 Vector3.Lerp(__instance.transform.localPosition, ____targetLocalPosition, t);

//             _updateFOV.Invoke(__instance, new object[] { deltaTime });
//             _updateRotation.Invoke(__instance, null);

//             return false;
//         }
//     }
// }