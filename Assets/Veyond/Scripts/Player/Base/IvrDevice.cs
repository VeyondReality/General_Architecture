using UnityEngine;

namespace Shooting.Player.Base
{
    public interface IvrDevice
    {
        GameObject gameObject { get; set; }

        Transform originPos { get; set; }

        void SetOriginPosition();

    }
}