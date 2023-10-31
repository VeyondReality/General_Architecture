using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Veyond.Tool.Base
{
    public interface ILoader
    {
        string SceneFolder { get; }

        Task LoadSceneSync(string scenename, LoadSceneMode loadmode);
    }
}