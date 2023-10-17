using Zenject;
using Shooting.Flow.Manager;
using Shooting.Flow.Base;
using Shooting.Flow.Facade;
using Shooting.Flow.Factory;
using Shooting.Flow.Phase;

namespace Shooting.Installer
{
    public class LobbyInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Lobby>().AsSingle().NonLazy();
            BindPhase();
        }

        private void BindPhase()
        {
            Container.BindInterfacesAndSelfTo<FlowFacade.LobbyFlowFacade>().AsSingle();
            Container.BindInterfacesAndSelfTo<PhaseFactory.LobbyPhaseFactory>().AsSingle();

            Container.BindFactory<IPhase, LobbyPhase.Factory>().To<LobbyPhase>().WhenInjectedInto<PhaseFactory.LobbyPhaseFactory>();
        }
    }
}