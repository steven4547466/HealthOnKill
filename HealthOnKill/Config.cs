using System.ComponentModel;
using Exiled.API.Interfaces;

namespace HealthOnKill
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Determines if the plugin should use random values")]
        public bool isHealthRegenRandom { get; set; } = true;

        [Description("If isHealthRegenRandom is set to false, SCP-049 will regen this set amount")]
        public int scp049HealthOnZomebieRaisedSet { get; set; } = 40;
        [Description("If isHealthRegenRandom is set to true, SCP-049's random health regen will be at least this much")]
        public int scp049HealthOnZombieRaisedRandomLowerBounds { get; set; } = 25; 
        [Description("If isHealthRegenRandom is set to true, SCP-049's random health regen will be at most this much")]
        public int scp049HealthOnZombieRaisedRandomUpperBounds { get; set; } = 75;

        [Description("If isHealthRegenRandom is set to false, SCP-049-2 will regen this set amount")]
        public int scp0492HealthOnKillSet { get; set; } = 40;
        [Description("If isHealthRegenRandom is set to true, SCP-049-2's random health regen will be at least this much")]
        public int scp0492HealthOnKillRandomLowerBounds { get; set; } = 25;
        [Description("If isHealthRegenRandom is set to true, SCP-049-2's random health regen will be at most this much")]
        public int scp0492HealthOnKillRandomUpperBounds { get; set; } = 50;

        [Description("If isHealthRegenRandom is set to false, SCP-106 will regen this set amount")]
        public int scp106HealthOnKillSet { get; set; } = 40;
        [Description("If isHealthRegenRandom is set to true, SCP-106's random health regen will be at least this much")]
        public int scp106HealthOnKillRandomLowerBounds { get; set; } = 25;
        [Description("If isHealthRegenRandom is set to true, SCP-106's random health regen will be at most this much")]
        public int scp106HealthOnKillRandomUpperBounds { get; set; } = 50;

        [Description("If isHealthRegenRandom is set to false, SCP-173 will regen this set amount")]
        public int scp173HealthOnKillSet { get; set; } = 40;
        [Description("If isHealthRegenRandom is set to true, SCP-173's random health regen will be at least this much")]
        public int scp173HealthOnKillRandomLowerBounds { get; set; } = 25;
        [Description("If isHealthRegenRandom is set to true, SCP-173's random health regen will be at most this much")]
        public int scp173HealthOnKillRandomUpperBounds { get; set; } = 50;

        [Description("If isHealthRegenRandom is set to false, SCP-939 will regen this set amount")]
        public int scp939HealthOnKillSet { get; set; } = 40;
        [Description("If isHealthRegenRandom is set to true, SCP-939's random health regen will be at least this much")]
        public int scp939HealthOnKillRandomLowerBounds { get; set; } = 25;
        [Description("If isHealthRegenRandom is set to true, SCP-939's random health regen will be at most this much")]
        public int scp939HealthOnKillRandomUpperBounds { get; set; } = 50;
    }
}
