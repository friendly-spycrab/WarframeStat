using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class News
    {
        [JsonProperty("asString")]
        public string AsString { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("primeAccess")]
        public bool PrimeAccess { get; set; }

        [JsonProperty("priority")]
        public bool Priority { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("stream")]
        public bool Stream { get; set; }

        [JsonProperty("translations")]
        public Translations Translations { get; set; }

        [JsonProperty("update")]
        public bool Update { get; set; }
    }

}
