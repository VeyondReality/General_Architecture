using Veyond.Player.Base;
using UnityEngine;
using Zenject;

namespace Veyond.Player.Facades
{
    public class TransitionFacades : MonoBehaviour
    {
        [Inject]
        ITransition transition;

        [ContextMenu("TestFadeIn")]
        public void FadeIn()
        {
            transition.FadeIn(1.5f);
        }

        [ContextMenu("TestFadeOut")]
        public void FadeOut()
        {
            transition.FadeOut(1.5f);
        }
    }
}