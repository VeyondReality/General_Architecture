using Shooting.Flow.Facade;
using Zenject;

namespace Shooting.Flow.Manager
{
    public class Verification : IInitializable
    {
        [Inject]
        FlowFacade.VerificationFlowFacade phaseFacade;

        public void Initialize()
        {
            phaseFacade.EnterVerificationPhase();
        }
    }
}