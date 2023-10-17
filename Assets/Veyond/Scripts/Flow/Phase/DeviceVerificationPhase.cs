using Shooting.Flow.Base;
using Shooting.Player.Facades;
using Shooting.Tool.Base;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Shooting.Flow.Phase
{
    public class DeviceVerificationPhase : IPhase
    {
        [Inject]
        ILoader assetLoader;

        [Inject]
        CharacterFacades characterFacades;

        [Inject]
        TransitionFacades transitionFacades;

        public void enterPhase()
        {
            Debug.Log($"<color=green>Enter {nameof(DeviceVerificationPhase)}. </color>");
            Init();
        }

        private async void Init()
        {
            characterFacades.Init();

            //這裡要做人員的驗證過了才可以進入下一個場
            var IsAuthed = await ProcessVerification();

            if (IsAuthed)
                GoToLobbyScene();
            else
            {
                //秀出聯絡廠商UI
                transitionFacades.FadeOut();
            }
        }

        private async Task<bool> ProcessVerification()
        {
            await Task.Yield();
            return true;
        }

        private void GoToLobbyScene()
        {
            assetLoader.LoadSceneSync(assetLoader.SceneFolder + "Lobby", LoadSceneMode.Single);
        }

        public class Factory : PlaceholderFactory<IPhase> { }
    }
}