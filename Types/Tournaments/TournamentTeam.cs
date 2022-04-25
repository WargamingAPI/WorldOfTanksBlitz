using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

#nullable enable

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public struct TournamentTeam
    {
        public string title { get; set; }
        public long? clan_id { get; set; }
        public long team_id { get; set; }
        public long tournament_id { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<TournamentPlayer> players { get; set; }

        public TeamStatus status { get; set; }
    }
}