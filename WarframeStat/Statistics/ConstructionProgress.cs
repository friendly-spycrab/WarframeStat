using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class ConstructionProgress
    {
        [JsonProperty("fomorianProgress")]
        public string FomorianProgress { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("razorbackProgress")]
        public string RazorbackProgress { get; set; }

        [JsonProperty("unknownProgress")]
        public string UnknownProgress { get; set; }
    }

}
