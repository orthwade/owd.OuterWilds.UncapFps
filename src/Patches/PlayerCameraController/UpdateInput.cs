// using HarmonyLib;
// using UnityEngine;

// namespace owd.OuterWilds.UncapFps
// {
//     [HarmonyPatch(typeof(PlayerCameraController), "UpdateInput")]
//     class Patch_UpdateInput
//     {
//         static bool Prefix(
//             PlayerCameraController __instance,
//             float deltaTime,

//             ref float ____degreesX,
//             ref float ____degreesY,
//             ref bool ____isSnapping,
//             ref bool ____isLockedOn,
//             ref bool ____zoomed,
//             ref float ____initFOV,
//             ref OWCamera ____playerCamera,
//             ref ShipCockpitController ____shipController
//         )
//         {
//             if(__instance == null)
//             {
//                 return true;
//             }
//             bool flag = ____shipController != null &&
//                         ____shipController.AllowFreeLook() &&
//                         OWInput.IsPressed(InputLibrary.freeLook, 0f);

//             bool flag2 = OWInput.IsInputMode(
//                 InputMode.Character |
//                 InputMode.ScopeZoom |
//                 InputMode.NomaiRemoteCam |
//                 InputMode.PatchingSuit);

//             if (____isSnapping || ____isLockedOn ||
//                 (PlayerState.InZeroG() && PlayerState.IsWearingSuit()) ||
//                 (!flag2 && !flag))
//             {
//                 return false;
//             }

//             bool flag3 = Locator.GetAlarmSequenceController() != null &&
//                          Locator.GetAlarmSequenceController().IsAlarmWakingPlayer();

//             Vector2 vector = Vector2.one;
//             vector *= ((____zoomed || flag3) ? PlayerCameraController.ZOOM_SCALAR : 1f);
//             vector *= ____playerCamera.fieldOfView / ____initFOV;

//             if (Time.timeScale > 1f)
//             {
//                 vector /= Time.timeScale;
//             }

//             float num = deltaTime;

//             if (InputUtil.IsMouseMoveAxis(InputLibrary.look.AxisID))
//             {
//                 num = 0.01666667f; // KEEP as requested
//             }

//             if (flag)
//             {
//                 Vector2 axisValue = OWInput.GetAxisValue(InputLibrary.look, InputMode.All);

//                 ____degreesX += axisValue.x * 180f * vector.x * num;
//                 ____degreesY += axisValue.y * 180f * vector.y * num;

//                 return false;
//             }

//             float num2 = OWInput.UsingGamepad()
//                 ? PlayerCameraController.GAMEPAD_LOOK_RATE_Y
//                 : PlayerCameraController.LOOK_RATE;

//             ____degreesY += OWInput.GetAxisValue(InputLibrary.look, InputMode.All).y
//                             * num2 * vector.y * num;

//             ____degreesX += OWInput.GetAxisValue(InputLibrary.look, InputMode.All).x
//                             * num2 * vector.x * num * 2.0f;

//             return false;
//         }
//     }
// }