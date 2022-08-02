using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Structs
{
    public struct Logo
    {
        [JsonProperty("original")] public string Original;

        [JsonProperty("preview")] public string Preview;
    }
}