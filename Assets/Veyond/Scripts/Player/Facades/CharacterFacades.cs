using Shooting.Player.Base;
using UnityEngine;
using Zenject;

namespace Shooting.Player.Facades
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