using UnityEngine;

namespace Veyond.Player.Base
{
    public interface IvrDevice
    {
        GameObject gameObject { get; set; }

        Transform originPos { get; set; }

        void SetOriginPosition();

    }
}