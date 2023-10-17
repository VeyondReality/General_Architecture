using Zenject;

namespace Shooting.Installer
{
    public class SystemInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            GameToolInstaller.Install(Container);
        }
    }
}