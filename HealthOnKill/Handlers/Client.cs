using Exiled.Events.EventArgs;
using System;
using System.Linq;

namespace HealthOnKill.Handlers
{
    class Client
    {
        private Random r = new Random();

        public void OnPlayerDeath(DiedEventArgs ev)
        {
            if (ev.Killer.Team == Team.SCP)
            {
                if (ev.Killer.Role == RoleType.Scp93989 || ev.Killer.Role == RoleType.Scp93953)
                {
                    if (HealthOnKill.instance.Config.isHealthRegenRandom)
                    {
                        int rand = r.Next(HealthOnKill.instance.Config.scp939HealthOnKillRandomLowerBounds, HealthOnKill.instance.Config.scp939HealthOnKillRandomUpperBounds);
                        ev.Killer.Health += rand;
                    }
                    else
                    {
                        ev.Killer.Health += HealthOnKill.instance.Config.scp939HealthOnKillSet;
                    }
                }
                else if (ev.Killer.Role == RoleType.Scp173)
                {
                    if (HealthOnKill.instance.Config.isHealthRegenRandom)
                    {
                        int rand = r.Next(HealthOnKill.instance.Config.scp173HealthOnKillRandomLowerBounds, HealthOnKill.instance.Config.scp173HealthOnKillRandomUpperBounds);
                        ev.Killer.Health += rand;
                    }
                    else
                    {
                        ev.Killer.Health += HealthOnKill.instance.Config.scp173HealthOnKillSet;
                    }
                }
                else if (ev.Killer.Role == RoleType.Scp0492)
                {
                    if (HealthOnKill.instance.Config.isHealthRegenRandom)
                    {
                        int rand = r.Next(HealthOnKill.instance.Config.scp0492HealthOnKillRandomLowerBounds, HealthOnKill.instance.Config.scp0492HealthOnKillRandomUpperBounds);
                        ev.Killer.Health += rand;
                    }
                    else
                    {
                        ev.Killer.Health += HealthOnKill.instance.Config.scp0492HealthOnKillSet;
                    }
                }
            }
        }
        public void OnZombieRaised(FinishingRecallEventArgs ev)
        {
            Exiled.API.Features.Player Player049 = Exiled.API.Features.Player.List.FirstOrDefault(x => x.Role == RoleType.Scp049);
            
            if (HealthOnKill.instance.Config.isHealthRegenRandom)
            {
                int rand = r.Next(HealthOnKill.instance.Config.scp049HealthOnZombieRaisedRandomLowerBounds, HealthOnKill.instance.Config.scp049HealthOnZombieRaisedRandomUpperBounds);
                Player049.Health += rand;
            }
            else
            {
                Player049.Health += HealthOnKill.instance.Config.scp049HealthOnZomebieRaisedSet;
            }
            
        }
        public void OnPocketDimensionDeath(FailingEscapePocketDimensionEventArgs ev)
        {
            Exiled.API.Features.Player Player106 = Exiled.API.Features.Player.List.FirstOrDefault(x => x.Role == RoleType.Scp106);
           
            if (Player106 != null)
            {
                if (HealthOnKill.instance.Config.isHealthRegenRandom)
                {
                    int rand = r.Next(5, 15);
                    Player106.Health += rand;
                }
                else
                {
                    Player106.Health += HealthOnKill.instance.Config.scp106HealthOnKillSet;
                }
            }
        }
    }
}
