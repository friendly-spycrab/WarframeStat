using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class CountedItem
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}
