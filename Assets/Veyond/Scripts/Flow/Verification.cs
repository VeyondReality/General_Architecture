using Veyond.Flow.Facade;
using Zenject;

namespace Veyond.Flow.Manager
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