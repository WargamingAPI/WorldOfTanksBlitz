using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public class TournamentInfo : Tournament
    {
        public string Rules;

        [JsonProperty("other_rules")] public string OtherRules;

        [JsonProperty("prize_description")] public string PrizeDescription;

        [JsonProperty("max_players_count")] public byte MaxPlayersCount;

        [JsonProperty("min_players_count")] public byte MinPlayersCount;

        public Teams Teams { get; set; }

        [JsonProperty("media_links")] public Media? MediaLinks;
    }
}