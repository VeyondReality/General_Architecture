using Veyond.Flow.Base;
using Veyond.Flow.Facade;
using Veyond.Flow.Factory;
using Veyond.Flow.Manager;
using Veyond.Flow.Phase;
using Zenject;

namespace Veyond.Installer
{
    public class VerificationInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Verification>().AsSingle();
            BindPhase();
        }

        private void BindPhase()
        {
            Container.BindInterfacesAndSelfTo<FlowFacade.VerificationFlowFacade>().AsSingle();
            Container.BindInterfacesAndSelfTo<PhaseFactory.VerificationPhaseFactory>().AsSingle();

            Container.BindFactory<IPhase, DeviceVerificationPhase.Factory>().To<DeviceVerificationPhase>().WhenInjectedInto<PhaseFactory.VerificationPhaseFactory>();
        }
    }
}