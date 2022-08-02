#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Enums;

namespace WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Structs
{
    public struct Team
    {
        public string Title;

        [JsonProperty("clan_id")] public long? ClanId;
        [JsonProperty("team_id")] public long TeamId;
        [JsonProperty("tournament_id")] public long TournamentId;

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<Player> Players;

        public TeamStatus Status;
    }
}