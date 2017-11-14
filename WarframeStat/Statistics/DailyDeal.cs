using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.Statistics
{
    public partial class DailyDeal
    {
        [JsonProperty("discount")]
        public long Discount { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("originalPrice")]
        public long OriginalPrice { get; set; }

        [JsonProperty("salePrice")]
        public long SalePrice { get; set; }

        [JsonProperty("sold")]
        public long Sold { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

}
