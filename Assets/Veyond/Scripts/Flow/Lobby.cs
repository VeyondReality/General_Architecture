using Shooting.Flow.Facade;
using Zenject;

namespace Shooting.Flow.Manager
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