using Shooting.Flow.Base;
using Shooting.Flow.Facade;
using Shooting.Flow.Factory;
using Shooting.Flow.Manager;
using Shooting.Flow.Phase;
using Zenject;

namespace Shooting.Installer
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