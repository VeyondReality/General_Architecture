using UnityEngine;
using Zenject;

namespace Veyond.Player.Base
{
    public interface IHand
    {
        Animator animator { get;}

        GameObject gameObject { get;}

        void ShowHandModel();

        void HideHandModel();

        void PlayHandGrabHold();

        void PlayHandFistHold();

        void PlayHandGrabRelease();

        void PlayHandFistRelease();
    }
}