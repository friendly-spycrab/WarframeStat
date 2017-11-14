using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class Job
    {
        [JsonProperty("enemyLevels")]
        public List<long> EnemyLevels { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("standingStages")]
        public List<long> StandingStages { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
