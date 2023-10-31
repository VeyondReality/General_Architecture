using Veyond.Flow.Facade;
using Zenject;

namespace Veyond.Flow.Manager
{
    public class StartUp : IInitializable
    {
        [Inject]
        FlowFacade.InitFlowFacade phaseFacade;

        public void Initialize()
        {
            phaseFacade.EnterInitPhase();
        }
    }
}