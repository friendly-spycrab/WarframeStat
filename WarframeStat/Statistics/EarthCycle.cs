using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class EarthCycle
    {
        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("isDay")]
        public bool IsDay { get; set; }

        [JsonProperty("timeLeft")]
        public string TimeLeft { get; set; }
    }
}
