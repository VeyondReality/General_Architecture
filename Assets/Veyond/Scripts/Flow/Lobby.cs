using Veyond.Flow.Facade;
using Zenject;

namespace Veyond.Flow.Manager
{
    public class Lobby : IInitializable
    {
        [Inject]
        FlowFacade.LobbyFlowFacade phaseFacade;

        public void Initialize()
        {
            phaseFacade.EnterLobbyPhase();
        }
    }
}