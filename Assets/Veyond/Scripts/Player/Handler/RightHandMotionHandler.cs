using HTC.UnityPlugin.Vive;
using Shooting.Player.Facades;
using UnityEngine;
using Zenject;

namespace Shooting.Player.Handler
{
    public class RightHandMotionHandler : MonoBehaviour, ITickable
    {
        [Inject]
        RightHandFacades rightHandFacades;

        public void Tick()
        {
            if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Grip))
                OnGrabPressDown();

            if (ViveInput.GetPressUp(HandRole.RightHand, ControllerButton.Grip))
                OnGrabPressUp();
        }

        [ContextMenu("TestOnGrabPressUp")]
        private void OnGrabPressUp()
        {
            rightHandFacades.HandGrabRelease();
        }

        [ContextMenu("TestOnGrabPressDown")]
        private void OnGrabPressDown()
        {
            rightHandFacades.HandGrabHold();
        }
    }
}