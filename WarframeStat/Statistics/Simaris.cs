using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{

    public partial class Simaris
    {
        [JsonProperty("asString")]
        public string AsString { get; set; }

        [JsonProperty("isTargetActive")]
        public bool IsTargetActive { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }
    }
}
