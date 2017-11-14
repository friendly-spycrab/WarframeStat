using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class Mission
    {
        [JsonProperty("archwingRequired")]
        public bool ArchwingRequired { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("maxEnemyLevel")]
        public long MaxEnemyLevel { get; set; }

        [JsonProperty("maxWaveNum")]
        public long? MaxWaveNum { get; set; }

        [JsonProperty("minEnemyLevel")]
        public long MinEnemyLevel { get; set; }

        [JsonProperty("nightmare")]
        public bool Nightmare { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("reward")]
        public Reward Reward { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
