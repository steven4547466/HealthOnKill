using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.Handlers;
using Exiled.API.Features;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Interfaces;
using Exiled.Loader;
using Exiled.Updater.Models;
using Exiled.Boostrap;
using Exiled.Events.Extensions;
using System.Linq;

namespace HealthOnKill.Handlers
{
    class Client
    {
        public void OnPlayerDeath(DiedEventArgs ev)
        {
            
            if (ev.Killer.Team == Team.SCP)
            {
                if (ev.Killer.Role == RoleType.Scp93989 || ev.Killer.Role == RoleType.Scp93953)
                {
                    if (HealthOnKill.Instance.Config.isHealthRegenRandom)
                    {
                        Random r = new Random();
                        int rand = r.Next(HealthOnKill.Instance.Config.scp939HealthOnKillRandomLowerBounds, HealthOnKill.Instance.Config.scp939HealthOnKillRandomUpperBounds);
                        ev.Killer.Health += rand;

                    }

                    else
                    {
                        ev.Killer.Health += HealthOnKill.Instance.Config.scp939HealthOnKillSet;
                    }
                    
                }
                
                else if (ev.Killer.Role == RoleType.Scp173)
                {
                    if (HealthOnKill.Instance.Config.isHealthRegenRandom)
                    {
                        Random r = new Random();
                        int rand = r.Next(HealthOnKill.Instance.Config.scp173HealthOnKillRandomLowerBounds, HealthOnKill.Instance.Config.scp173HealthOnKillRandomUpperBounds);
                        ev.Killer.Health += rand;

                    }

                    else
                    {
                        ev.Killer.Health += HealthOnKill.Instance.Config.scp173HealthOnKillSet;
                    }
                }
                
                else if (ev.Killer.Role == RoleType.Scp0492)
                {
                    if (HealthOnKill.Instance.Config.isHealthRegenRandom)
                    {
                        Random r = new Random();
                        int rand = r.Next(HealthOnKill.Instance.Config.scp0492HealthOnKillRandomLowerBounds, HealthOnKill.Instance.Config.scp0492HealthOnKillRandomUpperBounds);
                        ev.Killer.Health += rand;

                    }

                    else
                    {
                        ev.Killer.Health += HealthOnKill.Instance.Config.scp0492HealthOnKillSet;
                    }
                }

            }
        }
        public void OnZombieRaised(FinishingRecallEventArgs ev)
        {
            Exiled.API.Features.Player Player049 = Exiled.API.Features.Player.List.FirstOrDefault(x => x.Role == RoleType.Scp049);
            
            if (HealthOnKill.Instance.Config.isHealthRegenRandom)
            {
                Random r = new Random();
                int rand = r.Next(HealthOnKill.Instance.Config.scp049HealthOnZombieRaisedRandomLowerBounds, HealthOnKill.Instance.Config.scp049HealthOnZombieRaisedRandomUpperBounds);
                Player049.Health += rand;
            }
            else
            {
                Player049.Health += HealthOnKill.Instance.Config.scp049HealthOnZomebieRaisedSet;
            }
            
        }
        public void OnPocketDimensionDeath(FailingEscapePocketDimensionEventArgs ev)
        {
            Exiled.API.Features.Player Player106 = Exiled.API.Features.Player.List.FirstOrDefault(x => x.Role == RoleType.Scp106);
           
            if (Player106 != null)
            {
                if (HealthOnKill.Instance.Config.isHealthRegenRandom)
                {
                    Random r = new Random();
                    int rand = r.Next(5, 15);
                    Player106.Health += rand;
                }
                else
                {
                    Player106.Health += HealthOnKill.Instance.Config.scp106HealthOnKillSet;
                }
            }
        }
    }
}
