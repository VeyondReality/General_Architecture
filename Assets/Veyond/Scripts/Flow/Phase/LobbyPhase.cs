using Shooting.Flow.Base;
using Shooting.Player.Facades;
using Shooting.Tool.Base;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Shooting.Flow.Phase
{
    public class LobbyPhase : IPhase
    {
        [Inject]
        ILoader assetLoader;

        [Inject]
        CharacterFacades characterFacades;

        [Inject]
        TransitionFacades transitionFacades;
        public void enterPhase()
        {
            Debug.Log($"<color=green>Enter {nameof(LobbyPhase)}. </color>");
            Init();
        }

        private async void Init()
        {
            characterFacades.Init();

            await Task.Yield();

            transitionFacades.FadeOut();
        }

        public class Factory : PlaceholderFactory<IPhase> { }
    }
}