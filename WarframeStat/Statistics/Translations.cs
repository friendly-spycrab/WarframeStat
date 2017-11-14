using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class Translations
    {
        [JsonProperty("de")]
        public string De { get; set; }

        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("es")]
        public string Es { get; set; }

        [JsonProperty("fr")]
        public string Fr { get; set; }

        [JsonProperty("it")]
        public string It { get; set; }

        [JsonProperty("ja")]
        public string Ja { get; set; }

        [JsonProperty("ko")]
        public string Ko { get; set; }

        [JsonProperty("pl")]
        public string Pl { get; set; }

        [JsonProperty("pt")]
        public string Pt { get; set; }

        [JsonProperty("ru")]
        public string Ru { get; set; }

        [JsonProperty("tc")]
        public string Tc { get; set; }

        [JsonProperty("tr")]
        public string Tr { get; set; }

        [JsonProperty("uk")]
        public string Uk { get; set; }

        [JsonProperty("zh")]
        public string Zh { get; set; }
    }

}
