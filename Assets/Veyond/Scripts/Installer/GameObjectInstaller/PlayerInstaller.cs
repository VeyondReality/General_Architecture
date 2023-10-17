using Shooting.Player.Base;
using Shooting.Player.Character;
using Shooting.Player.Hand;
using Shooting.Player.Mask;
using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Shooting.Installer
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField]
        Settings settings = null;

        public override void InstallBindings()
        {
            Container.Bind<IvrDevice>().To<VrDevice>().AsSingle().WithArguments(settings.vrDeviceObject , settings.originPos);

            Container.Bind<IHand>().WithId("Right").To<RightHand>().AsSingle().WithArguments(settings.rightHandAnim , settings.rightHandObject);
            Container.Bind<IHand>().WithId("Left").To<LeftHand>().AsSingle().WithArguments(settings.leftHandAnim , settings.leftHandObject);

            Container.Bind<ITransition>().To<Transition>().AsSingle().WithArguments(settings.maskImage);
        }

        [Serializable]
        public class Settings
        {
            [Header("GameObject")]
            public GameObject vrDeviceObject;
            public GameObject rightHandObject;
            public GameObject leftHandObject;
            [Header("Animator")]
            public Animator rightHandAnim;
            public Animator leftHandAnim;
            [Header("Image")]
            public Image maskImage;
            [Header("Transform")]
            public Transform originPos;
        }
    }
}