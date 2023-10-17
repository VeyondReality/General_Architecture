using Shooting.Tool.Base;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace Shooting.Tool.Loader
{
    public class AssetLoader : ILoader
    {
        private const string _sceneFolder = "Scenes/";
        public string SceneFolder { get => _sceneFolder; }

        public async Task LoadSceneSync(string scenename, LoadSceneMode loadmode)
        {
            var loadHandle = Addressables.LoadSceneAsync(scenename, loadmode);
            await loadHandle.Task;

            if (loadHandle.Status == AsyncOperationStatus.Failed)
            {
                Debug.Log($"<color=red>Load {scenename} failed.</color>");
            }
        }
    }
}

