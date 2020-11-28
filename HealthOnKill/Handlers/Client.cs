﻿using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System.Linq;
using UnityEngine;

namespace HealthOnKill.Handlers
{
    class Client
    {
        internal void OnPlayerDeath(DiedEventArgs ev)
        {
            if (ev.Killer.Team == Team.SCP)
            {
				if (ev.Killer.Role == RoleType.Scp93989 || ev.Killer.Role == RoleType.Scp93953)
				{
					int health = HealthOnKill.instance.Config.isHealthRegenRandom ?
						(int)ev.Killer.Health + Random.Range(HealthOnKill.instance.Config.scp939HealthOnKillRandomLowerBounds, HealthOnKill.instance.Config.scp939HealthOnKillRandomUpperBounds) :
						(int)ev.Killer.Health + HealthOnKill.instance.Config.scp939HealthOnKillSet;
                    ev.Killer.Health = Mathf.Clamp(health, 0f, ev.Killer.MaxHealth);
                }
				else if (ev.Killer.Role == RoleType.Scp173)
				{
                    int health = HealthOnKill.instance.Config.isHealthRegenRandom ?
						(int)ev.Killer.Health + Random.Range(HealthOnKill.instance.Config.scp173HealthOnKillRandomLowerBounds, HealthOnKill.instance.Config.scp173HealthOnKillRandomUpperBounds) :
						(int)ev.Killer.Health + HealthOnKill.instance.Config.scp173HealthOnKillSet;
                    ev.Killer.Health = Mathf.Clamp(health, 0f, ev.Killer.MaxHealth);
                }
				else if (ev.Killer.Role == RoleType.Scp0492)
				{
                    int health = HealthOnKill.instance.Config.isHealthRegenRandom ?
						(int)ev.Killer.Health + Random.Range(HealthOnKill.instance.Config.scp0492HealthOnKillRandomLowerBounds, HealthOnKill.instance.Config.scp0492HealthOnKillRandomUpperBounds) :
						(int)ev.Killer.Health + HealthOnKill.instance.Config.scp0492HealthOnKillSet;
                    ev.Killer.Health = Mathf.Clamp(health, 0f, ev.Killer.MaxHealth);
                }
				else if (ev.Killer.Role == RoleType.Scp106 && Warhead.IsDetonated)
				{
                    int health = HealthOnKill.instance.Config.isHealthRegenRandom ?
						(int)ev.Killer.Health + Random.Range(5, 15) :
						(int)ev.Killer.Health + HealthOnKill.instance.Config.scp106HealthOnKillSet;
                    ev.Killer.Health = Mathf.Clamp(health, 0f, ev.Killer.MaxHealth);
                }
            }
        }

        internal void OnZombieRaised(FinishingRecallEventArgs ev)
        {
            int health = HealthOnKill.instance.Config.isHealthRegenRandom ? 
                (int)ev.Scp049.Health + Random.Range(HealthOnKill.instance.Config.scp049HealthOnZombieRaisedRandomLowerBounds, HealthOnKill.instance.Config.scp049HealthOnZombieRaisedRandomUpperBounds) :
                (int)ev.Scp049.Health + HealthOnKill.instance.Config.scp049HealthOnZomebieRaisedSet;
            ev.Scp049.Health = Mathf.Clamp(health, 0f, ev.Scp049.MaxHealth);
        }

        internal void OnPocketDimensionDeath(FailingEscapePocketDimensionEventArgs ev)
        {
            Player Player106 = Player.List.FirstOrDefault(x => x.Role == RoleType.Scp106);

            if (Player106 != null && !SerpentsHand.API.SerpentsHand.GetSHPlayers().Contains(ev.Player))
            {
                int health = HealthOnKill.instance.Config.isHealthRegenRandom ? 
                    (int)Player106.Health + Random.Range(5, 15) :
                    (int)Player106.Health + HealthOnKill.instance.Config.scp106HealthOnKillSet;
                Player106.Health = Mathf.Clamp(health, 0f, Player106.MaxHealth);
            }
        }
    }
}
