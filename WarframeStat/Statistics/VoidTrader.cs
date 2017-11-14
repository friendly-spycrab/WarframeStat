using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarframeStat.Statistics
{
    public partial class VoidTrader
    {
        [JsonProperty("activation")]
        public string Activation { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("endString")]
        public string EndString { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inventory")]
        public List<object> Inventory { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("psId")]
        public string PsId { get; set; }

        [JsonProperty("startString")]
        public string StartString { get; set; }
    }

}
