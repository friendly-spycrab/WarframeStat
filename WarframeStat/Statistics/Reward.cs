using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class Reward
    {
        [JsonProperty("asString")]
        public string AsString { get; set; }

        [JsonProperty("color")]
        public long Color { get; set; }

        [JsonProperty("countedItems")]
        public List<object> CountedItems { get; set; }

        [JsonProperty("credits")]
        public long Credits { get; set; }

        [JsonProperty("itemString")]
        public string ItemString { get; set; }

        [JsonProperty("items")]
        public List<string> Items { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

}
