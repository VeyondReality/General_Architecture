using ModestTree;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Shooting.Editor
{
    [CreateAssetMenu(menuName = "Veyond/Switch Scene Reference", fileName = "New SwitchSceneReference")]
    public class SwitchSceneMenuItem : ScriptableObject
    {
        [Header("Scenes")]
        public SceneAsset StartupScene;
        public SceneAsset VerificationScene;
        public SceneAsset LobbyScene;

        public static SwitchSceneMenuItem Instance
        {
            get
            {
                var assetGuids = AssetDatabase.FindAssets($"t:{typeof(SwitchSceneMenuItem).Name}");
                Assert.IsEqual(assetGuids.Length, 1);

                var assetPath = AssetDatabase.GUIDToAssetPath(assetGuids[0]);
                var asset = AssetDatabase.LoadAssetAtPath<SwitchSceneMenuItem>(assetPath);

                return asset;
            }
        }

        [MenuItem(ToolsPath.SwitchScene.Startup.Path, priority = ToolsPath.SwitchScene.Startup.Priority)]
        public static void SwitchToStartupScene()
        {
            OpenScene(Instance.StartupScene);
        }

        [MenuItem(ToolsPath.SwitchScene.Verification.Path, priority = ToolsPath.SwitchScene.Verification.Priority)]
        public static void SwitchToVerificationScene()
        {
            OpenScene(Instance.VerificationScene);
        }

        [MenuItem(ToolsPath.SwitchScene.Lobby.Path, priority = ToolsPath.SwitchScene.Lobby.Priority)]
        public static void SwitchToLobbyScene()
        {
            OpenScene(Instance.LobbyScene);
        }

        public static void OpenScene(SceneAsset sceneAsset)
        {
            string scenePath = AssetDatabase.GetAssetPath(sceneAsset);
            EditorSceneManager.OpenScene(scenePath , OpenSceneMode.Single);
        }

        public static void AddScene(SceneAsset sceneAsset)
        {
            string scenePath = AssetDatabase.GetAssetPath(sceneAsset);
            EditorSceneManager.OpenScene(scenePath , OpenSceneMode.Additive);
        }
    }
}