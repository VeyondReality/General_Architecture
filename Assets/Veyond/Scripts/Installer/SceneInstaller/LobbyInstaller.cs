using Zenject;
using Veyond.Flow.Manager;
using Veyond.Flow.Base;
using Veyond.Flow.Facade;
using Veyond.Flow.Factory;
using Veyond.Flow.Phase;

namespace Veyond.Installer
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