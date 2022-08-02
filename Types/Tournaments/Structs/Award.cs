using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Structs
{
    public struct Award
    {
        [JsonProperty("amount")] public uint Amount;

        [JsonProperty("currency")] public string Currency;
    }
}