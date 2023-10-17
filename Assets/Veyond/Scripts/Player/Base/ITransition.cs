using UnityEngine.UI;

namespace Shooting.Player.Base
{
    public interface ITransition
    {
        public Image image { get; set; }

        public void FadeIn(float duration);

        public void FadeOut(float duration);
    }
}