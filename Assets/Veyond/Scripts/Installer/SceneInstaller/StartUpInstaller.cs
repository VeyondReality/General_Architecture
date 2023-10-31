using Veyond.Flow.Base;
using Veyond.Flow.Facade;
using Veyond.Flow.Factory;
using Veyond.Flow.Manager;
using Veyond.Flow.Phase;
using Zenject;

namespace Veyond.Installer
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