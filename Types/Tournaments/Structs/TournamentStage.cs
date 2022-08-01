using System.Collections.Generic;
using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Tournaments.Enums;

namespace WorldOfTanksBlitz.Types.Tournaments.Structs
{
    public struct TournamentStage
    {
        public string Title;
        public string Description;
        
        public StageType Type;
        public StageState State;

        [JsonProperty("tournament_id")]
        public long TournamentId;
        [JsonProperty("stage_id")]
        public long StageId;
        
        [JsonProperty("victory_limit")]
        public long VictoryLimit;
        [JsonProperty("battle_limit")]
        public byte BattleLimit;
        
        [JsonProperty("end_at")]
        public long EndAt;
        [JsonProperty("start_at")]
        public long StartAt;
        
        [JsonProperty("groups_count")]
        public ushort GroupsCount;
        [JsonProperty("rounds_count")]
        public byte RoundsCount;
        
        [JsonProperty("max_tier")]
        public byte MaxTier;
        [JsonProperty("min_tier")]
        public byte MinTier;
        
        public IEnumerable<long> Rounds;
        public IEnumerable<Group> Groups;
    }
}