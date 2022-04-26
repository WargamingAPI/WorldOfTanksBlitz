using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public struct Award
    {
        [JsonProperty("amount")] public uint Amount { get; set; }

        [JsonProperty("currency")] public string Currency { get; set; }
    }
}