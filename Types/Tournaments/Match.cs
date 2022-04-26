using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Tournaments.Enums;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public struct Match
    {
        public string Id { get; set; }
        
        public long Round { get; set; }
        public TournamentState State { get; set; }

        [JsonProperty("group_id")] public long GroupId { get; set; }
        [JsonProperty("tournament_id")] public long TournamentId { get; set; }
        [JsonProperty("winner_team_id")] public long? WinnerTeamId { get; set; }
        [JsonProperty("stage_id")] public long StageId { get; set; }
        [JsonProperty("start_time")] public long StartTime { get; set; }
        
        [JsonProperty("next_match_for_looser")]
        public string NextMatchIdForLooser { get; set; }

        [JsonProperty("next_match_for_winner")]
        public string NextMatchIdForWinner { get; set; }

        [JsonProperty("team_1_id")] public long FirstTeamId { get; set; }
        [JsonProperty("team_1_score")] public long FirstTeamScore { get; set; }

        [JsonProperty("team_2_id")] public long SecondTeamId { get; set; }
        [JsonProperty("team_2_score")] public long SecondTeamScore { get; set; }
    }
}