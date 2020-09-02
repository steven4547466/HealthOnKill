using Exiled.API.Features;
using Exiled.Events.Handlers;
using Player = Exiled.Events.Handlers.Player;

namespace HealthOnKill
{
    public class HealthOnKill : Plugin<Config>
    {
        internal static HealthOnKill instance;

        private Handlers.Client client;

        public override void OnEnabled()
        {
            base.OnEnabled();
            instance = this;
            EventRegister();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            EventUnregister();
        }

        public void EventRegister()
        {
            client = new Handlers.Client();

            Player.Died += client.OnPlayerDeath;
            Player.FailingEscapePocketDimension += client.OnPocketDimensionDeath;
            Scp049.FinishingRecall += client.OnZombieRaised;
        }

        public void EventUnregister()
        {
            client = new Handlers.Client();

            Player.Died -= client.OnPlayerDeath;
            Player.FailingEscapePocketDimension -= client.OnPocketDimensionDeath;
            Scp049.FinishingRecall -= client.OnZombieRaised;
        }
    }
}
