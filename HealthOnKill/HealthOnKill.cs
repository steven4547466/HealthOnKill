using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Enums;
using System.Dynamic;

using Player = Exiled.Events.Handlers.Player;
using Exiled.Events.Handlers;

namespace HealthOnKill
{
    public class HealthOnKill : Plugin<Config>
    {
        private static readonly Lazy<HealthOnKill> LazyInstance = new Lazy<HealthOnKill>();
        public static HealthOnKill Instance => LazyInstance.Value;

        private Handlers.Client client;

        public override void OnEnabled()
        {
            base.OnEnabled();
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
