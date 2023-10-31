using Veyond.Player.Base;
using UnityEngine;
using Zenject;

namespace Veyond.Player.Facades
{
    public class CharacterFacades : MonoBehaviour
    {
        [Inject]
        private IvrDevice vrDevice;

        public void Init()
        {
            vrDevice.SetOriginPosition();
        }
    }
}