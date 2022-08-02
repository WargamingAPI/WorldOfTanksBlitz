using Newtonsoft.Json;
using WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Enums;

namespace WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Structs
{
    public struct Match
    {
        public string Id;

        public long Round;
        public TournamentState State;

        [JsonProperty("group_id")] public long GroupId;
        [JsonProperty("tournament_id")] public long TournamentId;
        [JsonProperty("winner_team_id")] public long? WinnerTeamId;
        [JsonProperty("stage_id")] public long StageId;
        [JsonProperty("start_time")] public long StartTime;

        [JsonProperty("next_match_for_looser")]
        public string NextMatchIdForLooser;

        [JsonProperty("next_match_for_winner")]
        public string NextMatchIdForWinner;

        [JsonProperty("team_1_id")] public long FirstTeamId;
        [JsonProperty("team_1_score")] public long FirstTeamScore;

        [JsonProperty("team_2_id")] public long SecondTeamId;
        [JsonProperty("team_2_score")] public long SecondTeamScore;
    }
}