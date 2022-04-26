#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Tournaments.Enums;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public struct TournamentTeam
    {
        public string Title { get; set; }

        [JsonProperty("clan_id")] public long? ClanId { get; set; }
        [JsonProperty("team_id")] public long TeamId { get; set; }
        [JsonProperty("tournament_id")] public long TournamentId { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<TournamentPlayer> Players { get; set; }

        public TeamStatus Status { get; set; }
    }
}