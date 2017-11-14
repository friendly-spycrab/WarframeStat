using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class DarkSector
    {
        [JsonProperty("defenderDeployemntActivation")]
        public long DefenderDeployemntActivation { get; set; }

        [JsonProperty("defenderMOTD")]
        public string DefenderMOTD { get; set; }

        [JsonProperty("defenderName")]
        public string DefenderName { get; set; }

        [JsonProperty("deployerClan")]
        public string DeployerClan { get; set; }

        [JsonProperty("deployerName")]
        public string DeployerName { get; set; }

        [JsonProperty("history")]
        public List<object> History { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isAlliance")]
        public bool IsAlliance { get; set; }
    }

}
