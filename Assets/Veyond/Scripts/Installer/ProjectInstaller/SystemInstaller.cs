using Zenject;

namespace Veyond.Installer
{
    public class SystemInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            GameToolInstaller.Install(Container);
        }
    }
}