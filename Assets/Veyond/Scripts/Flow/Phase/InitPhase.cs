using Shooting.Flow.Base;
using Shooting.Tool.Base;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Shooting.Flow.Phase
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
            //����ݦ��S���ƻ�n�������i�H�b�o�̰�
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