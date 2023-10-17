using Shooting.Flow.Facade;
using Zenject;

namespace Shooting.Flow.Manager
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