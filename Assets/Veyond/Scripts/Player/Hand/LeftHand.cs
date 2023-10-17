using HTC.UnityPlugin.Vive;
using Shooting.Player.Base;
using UnityEngine;
using Zenject;

namespace Shooting.Player.Hand
{
    public class LeftHand : IHand
    {
        [Inject]
        public Animator animator { get; private set; }

        [Inject]
        public GameObject gameObject { get; private set; }

        public void ShowHandModel()
        {
            gameObject.SetActive(true);
        }

        public void HideHandModel()
        {
            gameObject.SetActive(false);
        }

        public void PlayHandFistHold()
        {
            animator.SetTrigger(Animator.StringToHash("IsFistHold"));
        }

        public void PlayHandFistRelease()
        {
            animator.SetTrigger(Animator.StringToHash("IsFistRelease"));
        }

        public void PlayHandGrabHold()
        {
            animator.SetTrigger(Animator.StringToHash("IsGrabHold"));
        }

        public void PlayHandGrabRelease()
        {
            animator.SetTrigger(Animator.StringToHash("IsGrabRelease"));
        }
    }
}