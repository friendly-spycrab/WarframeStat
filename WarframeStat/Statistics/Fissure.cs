using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class Fissure
    {
        [JsonProperty("activation")]
        public string Activation { get; set; }

        [JsonProperty("enemy")]
        public string Enemy { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("missionType")]
        public string MissionType { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("tierNum")]
        public long TierNum { get; set; }
    }

}
