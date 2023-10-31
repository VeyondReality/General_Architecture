using Veyond.Tool.Base;
using Veyond.Tool.Loader;
using Zenject;

namespace Veyond.Installer
{
    public class GameToolInstaller : Installer<GameToolInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<ILoader>().To<AssetLoader>().AsSingle();
        }
    }
}