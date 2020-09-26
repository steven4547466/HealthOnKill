using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Loader;
using Player = Exiled.Events.Handlers.Player;

namespace HealthOnKill
{
    public class HealthOnKill : Plugin<Config>
    {
        internal static HealthOnKill instance;

        private Handlers.Client client;

        internal static bool isSH = false;

        public override void OnEnabled()
        {
            base.OnEnabled();
            CheckSH();
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

        internal void CheckSH()
        {
            foreach (var plugin in Loader.Plugins)
            {
                if (plugin.Name == "SerpentsHand")
                {
                    isSH = true;
                    return;
                }
            }
        }
    }
}
