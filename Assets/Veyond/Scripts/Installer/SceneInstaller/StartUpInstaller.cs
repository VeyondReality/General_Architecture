using Shooting.Flow.Base;
using Shooting.Flow.Facade;
using Shooting.Flow.Factory;
using Shooting.Flow.Manager;
using Shooting.Flow.Phase;
using Zenject;

namespace Shooting.Installer
{
    public class StartUpInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<StartUp>().AsSingle();
            BindPhase();
        }

        private void BindPhase()
        {
            Container.BindInterfacesAndSelfTo<FlowFacade.InitFlowFacade>().AsSingle();
            Container.BindInterfacesAndSelfTo<PhaseFactory.InitPhaseFactory>().AsSingle();

            Container.BindFactory<IPhase, InitPhase.Factory>().To<InitPhase>().WhenInjectedInto<PhaseFactory.InitPhaseFactory>();
        }
    }
}