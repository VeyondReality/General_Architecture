using Veyond.Flow.Base;
using Veyond.Flow.Factory;
using Zenject;

namespace Veyond.Flow.Facade
{
    public class FlowFacade
    {
        public class InitFlowFacade
        {
            [Inject]
            PhaseFactory.InitPhaseFactory initPhaseFactory;

            public void EnterInitPhase()
            {
                IPhase initPhase = initPhaseFactory.CreateInitPhase();
                initPhase.enterPhase();
            }
        }

        public class VerificationFlowFacade
        {
            [Inject]
            PhaseFactory.VerificationPhaseFactory verificationPhaseFactory;

            public void EnterVerificationPhase()
            {
                IPhase verificationPhase = verificationPhaseFactory.CreateVerificationPhase();
                verificationPhase.enterPhase();
            }
        }

        public class LobbyFlowFacade
        {
            [Inject]
            PhaseFactory.LobbyPhaseFactory LobbyPhaseFactory;

            public void EnterLobbyPhase()
            {
                IPhase lobbyPhase = LobbyPhaseFactory.CreateLobbyPhase();
                lobbyPhase.enterPhase();
            }
        }
    }
}