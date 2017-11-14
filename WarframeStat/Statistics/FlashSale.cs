using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class FlashSale
    {
        [JsonProperty("discount")]
        public long Discount { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isFeatured")]
        public bool IsFeatured { get; set; }

        [JsonProperty("isPopular")]
        public bool IsPopular { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("premiumOverride")]
        public long PremiumOverride { get; set; }
    }

}
