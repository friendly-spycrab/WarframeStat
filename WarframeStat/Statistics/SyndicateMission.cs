using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class SyndicateMission
    {
        [JsonProperty("activation")]
        public string Activation { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("jobs")]
        public List<Job> Jobs { get; set; }

        [JsonProperty("nodes")]
        public List<string> Nodes { get; set; }

        [JsonProperty("syndicate")]
        public string Syndicate { get; set; }
    }
}
