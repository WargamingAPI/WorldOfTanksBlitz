using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Accounts
{
    public class Statistics
    {
        [JsonProperty("all")]
        public All All { get; set; }
        
        [JsonProperty("clan")]
        public Clan Clan { get; set; }
        
        [JsonProperty("rating")]
        public Rating Rating { get; set; }
    }
}