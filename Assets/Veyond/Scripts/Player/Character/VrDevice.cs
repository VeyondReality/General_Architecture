using Shooting.Player.Base;
using UnityEngine;
using Zenject;

namespace Shooting.Player.Character
{
    public class VrDevice : IvrDevice
    {
        [Inject]
        public GameObject gameObject { get ; set ; }

        [Inject]
        public Transform originPos { get ; set ; }

        public void SetOriginPosition()
        {
            SetPosition(originPos.position);
        }

        private void SetPosition(Vector3 pos)
        {
            gameObject.transform.position = pos;
        }
    }
}