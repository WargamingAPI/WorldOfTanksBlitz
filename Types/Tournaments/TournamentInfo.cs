using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public class TournamentInfo : Tournament
    {
        public string Rules { get; set; }

        [JsonProperty("other_rules")] public string OtherRules { get; set; }

        [JsonProperty("prize_description")] public string PrizeDescription { get; set; }

        [JsonProperty("max_players_count")] public byte MaxPlayersCount { get; set; }

        [JsonProperty("min_players_count")] public byte MinPlayersCount { get; set; }

        public Teams Teams { get; set; }

        [JsonProperty("media_links")] public Media? MediaLinks { get; set; }
    }
}