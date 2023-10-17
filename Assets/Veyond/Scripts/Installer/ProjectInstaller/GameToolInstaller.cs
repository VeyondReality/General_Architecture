using Shooting.Tool.Base;
using Shooting.Tool.Loader;
using Zenject;

namespace Shooting.Installer
{
    public class GameToolInstaller : Installer<GameToolInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<ILoader>().To<AssetLoader>().AsSingle();
        }
    }
}