#nullable enable
using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public class TournamentPlayer
    {
        [JsonProperty("account_id")] public long AccountId { get; set; }

        public string? Image { get; set; } = null;
        public string Name { get; set; } = "";
        public string? Role { get; set; } = null;
    }
}