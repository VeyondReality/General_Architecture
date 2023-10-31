using Veyond.Flow.Base;
using Veyond.Flow.Phase;
using Zenject;

namespace Veyond.Flow.Factory
{
    public class PhaseFactory
    {
        public class InitPhaseFactory
        {
            [Inject]
            readonly InitPhase.Factory initFactory;

            public IPhase CreateInitPhase()
            {
                return initFactory.Create();
            }
        }

        public class VerificationPhaseFactory
        {
            [Inject]
            readonly DeviceVerificationPhase.Factory verificationFactory;

            public IPhase CreateVerificationPhase()
            {
                return verificationFactory.Create();
            }
        }

        public class LobbyPhaseFactory
        {
            [Inject]
            readonly LobbyPhase.Factory lobbyFactory;

            public IPhase CreateLobbyPhase()
            {
                return lobbyFactory.Create();
            }
        }
    }
}