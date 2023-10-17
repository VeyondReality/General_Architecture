using Shooting.Player.Base;
using UnityEngine;
using Zenject;

namespace Shooting.Player.Facades
{
    public class RightHandFacades : MonoBehaviour
    {
        [Inject(Id = "Right")]
        IHand hand;

        public void ShowHandModel()
        {
            hand.ShowHandModel();
        }

        public void HideHandModel()
        {
            hand.HideHandModel();
        }

        public void HandGrabHold()
        {
            hand.PlayHandGrabHold();
        }

        public void HandGrabRelease()
        {
            hand.PlayHandGrabRelease();
        }

        public void HandFistHold()
        {
            hand.PlayHandFistHold();
        }

        public void HandFistRelease()
        {
            hand.PlayHandFistRelease();
        }
    }
}