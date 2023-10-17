using Shooting.Player.Base;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Shooting.Player.Mask
{
    public class Transition : ITransition
    {
        [Inject]
        public Image image { get; set; }

        public async void FadeIn(float duration)
        {
            await Operation(0, 1, duration);
        }

        public async void FadeOut(float duration)
        {
            await Operation(1, 0, duration);
        }

        async Task Operation(float _from, float _to, float _totalTime)
        {
            float time = 0.0f;
            Color tempColor = image.color;

            while (time < _totalTime)
            {
                tempColor.a = Mathf.SmoothStep(_from, _to, time / _totalTime);
                image.color = tempColor;
                time += Time.deltaTime;
                await Task.Yield();
            }

            tempColor.a = _to;
            image.color = tempColor;
        }
    }
}