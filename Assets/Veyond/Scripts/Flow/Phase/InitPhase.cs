using Veyond.Flow.Base;
using Veyond.Tool.Base;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Veyond.Flow.Phase
{
    public class InitPhase : IPhase
    {
        [Inject]
        ILoader assetLoader;

        public void enterPhase()
        {
            Debug.Log($"<color=green>Enter {nameof(InitPhase)}. </color>");
            Init();
        }

        private async void Init()
        {
            //之後看有沒有甚麼要先做的可以在這裡做
            await Task.Yield();

            GoToVerificationScene();
        }

        private void GoToVerificationScene()
        {
            assetLoader.LoadSceneSync(assetLoader.SceneFolder + "Verification", LoadSceneMode.Single);
        }

        public class Factory : PlaceholderFactory<IPhase> { }
    }
}