using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarframeStat.Statistics
{
    public partial class MainStat
    {
        [JsonProperty("alerts")]
        [JsonProperty("alerts")]
        public List<Alert> Alerts { get; set; }

        [JsonProperty("cetusCycle")]
        public CetusCycle CetusCycle { get; set; }

        [JsonProperty("conclaveChallenges")]
        public List<ConclaveChallenge> ConclaveChallenges { get; set; }

        [JsonProperty("constructionProgress")]
        public ConstructionProgress ConstructionProgress { get; set; }

        [JsonProperty("dailyDeals")]
        public List<DailyDeal> DailyDeals { get; set; }

        [JsonProperty("darkSectors")]
        public List<DarkSector> DarkSectors { get; set; }

        [JsonProperty("earthCycle")]
        public EarthCycle EarthCycle { get; set; }

        [JsonProperty("events")]
        public List<object> Events { get; set; }

        [JsonProperty("fissures")]
        public List<Fissure> Fissures { get; set; }

        [JsonProperty("flashSales")]
        public List<FlashSale> FlashSales { get; set; }

        [JsonProperty("globalUpgrades")]
        public List<object> GlobalUpgrades { get; set; }

        [JsonProperty("invasions")]
        public List<Invasion> Invasions { get; set; }

        [JsonProperty("news")]
        public List<News> News { get; set; }

        [JsonProperty("persistentEnemies")]
        public List<object> PersistentEnemies { get; set; }

        [JsonProperty("simaris")]
        public Simaris Simaris { get; set; }

        [JsonProperty("sortie")]
        public Sortie Sortie { get; set; }

        [JsonProperty("syndicateMissions")]
        public List<SyndicateMission> SyndicateMissions { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("voidTrader")]
        public VoidTrader VoidTrader { get; set; }

        public static MainStat FromJson(string json)
        {
            return JsonConvert.DeserializeObject<MainStat>(json, new JsonSerializerSettings { MetadataPropertyHandling = MetadataPropertyHandling.Ignore, DateParseHandling = DateParseHandling.None, });
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings { MetadataPropertyHandling = MetadataPropertyHandling.Ignore, DateParseHandling = DateParseHandling.None, });
        }
    }

}
