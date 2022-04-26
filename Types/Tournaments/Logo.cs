using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public struct Logo
    {
        [JsonProperty("original")] public string Original { get; set; }

        [JsonProperty("preview")] public string Preview { get; set; }
    }
}