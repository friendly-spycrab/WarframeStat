using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class Invasion
    {
        [JsonProperty("activation")]
        public string Activation { get; set; }

        [JsonProperty("attackerReward")]
        public ErReward AttackerReward { get; set; }

        [JsonProperty("attackingFaction")]
        public string AttackingFaction { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("completion")]
        public double Completion { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("defenderReward")]
        public ErReward DefenderReward { get; set; }

        [JsonProperty("defendingFaction")]
        public string DefendingFaction { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("requiredRuns")]
        public long RequiredRuns { get; set; }

        [JsonProperty("rewardTypes")]
        public List<string> RewardTypes { get; set; }

        [JsonProperty("vsInfestation")]
        public bool VsInfestation { get; set; }
    }

}
