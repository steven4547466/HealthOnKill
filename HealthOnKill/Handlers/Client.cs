using Exiled.Events.EventArgs;
using System;
using System.Linq;
using SerpentsHand.API;

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
                        int health = (int)ev.Killer.Health + rand;
                        ev.Killer.Health = health < ev.Killer.MaxHealth ? health : ev.Killer.MaxHealth;
                    }
                    else
                    {
                        int health = (int)ev.Killer.Health + HealthOnKill.instance.Config.scp939HealthOnKillSet;
                        ev.Killer.Health = health < ev.Killer.MaxHealth ? health : ev.Killer.MaxHealth;
                    }
                }
                else if (ev.Killer.Role == RoleType.Scp173)
                {
                    if (HealthOnKill.instance.Config.isHealthRegenRandom)
                    {
                        int rand = r.Next(HealthOnKill.instance.Config.scp173HealthOnKillRandomLowerBounds, HealthOnKill.instance.Config.scp173HealthOnKillRandomUpperBounds);
                        int health = (int)ev.Killer.Health + rand;
                        ev.Killer.Health = health < ev.Killer.MaxHealth ? health : ev.Killer.MaxHealth;
                    }
                    else
                    {
                        int health = (int)ev.Killer.Health + HealthOnKill.instance.Config.scp173HealthOnKillSet;
                        ev.Killer.Health = health < ev.Killer.MaxHealth ? health : ev.Killer.MaxHealth;
                    }
                }
                else if (ev.Killer.Role == RoleType.Scp0492)
                {
                    if (HealthOnKill.instance.Config.isHealthRegenRandom)
                    {
                        int rand = r.Next(HealthOnKill.instance.Config.scp0492HealthOnKillRandomLowerBounds, HealthOnKill.instance.Config.scp0492HealthOnKillRandomUpperBounds);
                        int health = (int)ev.Killer.Health + rand;
                        ev.Killer.Health = health < ev.Killer.MaxHealth ? health : ev.Killer.MaxHealth;
                    }
                    else
                    {
                        int health = (int)ev.Killer.Health + HealthOnKill.instance.Config.scp0492HealthOnKillSet;
                        ev.Killer.Health = health < ev.Killer.MaxHealth ? health : ev.Killer.MaxHealth;
                    }
                }
            }
        }
        public void OnZombieRaised(FinishingRecallEventArgs ev)
        {
            if (HealthOnKill.instance.Config.isHealthRegenRandom)
            {
                int rand = r.Next(HealthOnKill.instance.Config.scp049HealthOnZombieRaisedRandomLowerBounds, HealthOnKill.instance.Config.scp049HealthOnZombieRaisedRandomUpperBounds);
                int health = (int)ev.Scp049.Health + rand;
                ev.Scp049.Health = health < ev.Scp049.MaxHealth ? health : ev.Scp049.MaxHealth;
            }
            else
            {
                int health = (int)ev.Scp049.Health + HealthOnKill.instance.Config.scp049HealthOnZomebieRaisedSet;
                ev.Scp049.Health = health < ev.Scp049.MaxHealth ? health : ev.Scp049.MaxHealth;
            }
            
        }
        public void OnPocketDimensionDeath(FailingEscapePocketDimensionEventArgs ev)
        {
            Exiled.API.Features.Player Player106 = Exiled.API.Features.Player.List.FirstOrDefault(x => x.Role == RoleType.Scp106);

            if (Player106 != null && !SerpentsHand.API.SerpentsHand.GetSHPlayers().Contains(ev.Player))
            {
                if (HealthOnKill.instance.Config.isHealthRegenRandom)
                {
                    int rand = r.Next(5, 15);
                    int health = (int)Player106.Health + rand;
                    Player106.Health = health < Player106.MaxHealth ? health : Player106.MaxHealth;
                }
                else
                {
                    int health = (int)Player106.Health + HealthOnKill.instance.Config.scp106HealthOnKillSet;
                    Player106.Health = health < Player106.MaxHealth ? health : Player106.MaxHealth;
                }
            }
        }
    }
}
