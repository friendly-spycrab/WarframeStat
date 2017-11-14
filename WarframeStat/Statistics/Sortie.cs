using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class Sortie
    {
        [JsonProperty("activation")]
        public string Activation { get; set; }

        [JsonProperty("boss")]
        public string Boss { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rewardPool")]
        public string RewardPool { get; set; }

        [JsonProperty("variants")]
        public List<Variant> Variants { get; set; }
    }

}
