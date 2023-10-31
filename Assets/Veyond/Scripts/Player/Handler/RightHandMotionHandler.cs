using HTC.UnityPlugin.Vive;
using Veyond.Player.Facades;
using UnityEngine;
using Zenject;

namespace Veyond.Player.Handler
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