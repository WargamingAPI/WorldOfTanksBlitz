using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Tournaments.Enums;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public class Tournament
    {
        public string Title { get; set; }
        public string Description { get; set; }

        [JsonProperty("tournament_id")] public long TournamentId { get; set; }

        [JsonProperty("end_at")] public long EndAt { get; set; }

        [JsonProperty("matches_start_at")] public long MatchesStartAt { get; set; }

        [JsonProperty("registration_end_at")] public long RegistrationEndAt { get; set; }

        [JsonProperty("registration_start_at")]
        public long RegistrationStartAt { get; set; }

        [JsonProperty("start_at")] public long StartAt { get; set; }

        public Logo Logo { get; set; }

        public Award? Fee { get; set; }
        public Award? Award { get; set; }

        [JsonProperty("winner_award")] public Award? WinnerAward { get; set; }

        public Status Status { get; set; }
    }
}