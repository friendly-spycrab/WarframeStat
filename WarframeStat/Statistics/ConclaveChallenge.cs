using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class ConclaveChallenge
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("asString")]
        public string AsString { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("daily")]
        public bool Daily { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endString")]
        public string EndString { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("rootChallenge")]
        public bool RootChallenge { get; set; }
    }

}
