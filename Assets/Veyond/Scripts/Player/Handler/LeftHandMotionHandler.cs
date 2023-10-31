using HTC.UnityPlugin.Vive;
using Veyond.Player.Facades;
using UnityEngine;
using Zenject;

namespace Veyond.Player.Handler
{
    public class LeftHandMotionHandler : MonoBehaviour, ITickable
    {
        [Inject]
        LeftHandFacades leftHandFacades;

        public void Tick()
        {
            if (ViveInput.GetPressDown(HandRole.LeftHand, ControllerButton.Grip))
                OnGrabPressDown();

            if (ViveInput.GetPressUp(HandRole.LeftHand, ControllerButton.Grip))
                OnGrabPressUp();
        }

        [ContextMenu("TestOnGrabPressUp")]
        private void OnGrabPressUp()
        {
            leftHandFacades.HandGrabRelease();
        }

        [ContextMenu("TestOnGrabPressDown")]
        private void OnGrabPressDown()
        {
            leftHandFacades.HandGrabHold();
        }
    }
}