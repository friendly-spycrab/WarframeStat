using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class Variant
    {
        [JsonProperty("boss")]
        public string Boss { get; set; }

        [JsonProperty("missionType")]
        public string MissionType { get; set; }

        [JsonProperty("modifier")]
        public string Modifier { get; set; }

        [JsonProperty("modifierDescription")]
        public string ModifierDescription { get; set; }

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("planet")]
        public string Planet { get; set; }
    }
}
