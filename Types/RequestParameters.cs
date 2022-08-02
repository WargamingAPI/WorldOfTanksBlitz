#nullable enable
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types
{
    public class RequestParameters : WargamingApi.Types.RequestParameters
    {
        public string? Status { get; set; }

        [JsonProperty("page_no")] public long? PageNo { get; set; }

        public IEnumerable<string>? Extra { get; set; }

        [JsonProperty("tank_id")] public IEnumerable<long>? TankId { get; set; }

        [JsonProperty("tournament_id")] public IEnumerable<long>? TournamentId { get; set; }

        [JsonProperty("clan_id")] public IEnumerable<long>? ClanId { get; set; }
        
        [JsonProperty("stage_id")] public IEnumerable<long>? StageId { get; set; }

        [JsonProperty("team_id")] public IEnumerable<long>? TeamId { get; set; }

        [JsonProperty("in_garage")] public bool? InGarage { get; set; }
    }

    public class RequestParameters<T> : RequestParameters
    {
        [JsonProperty("tank_id")] public new T TankId { get; set; } = default!;
        
        [JsonProperty("stage_id")] public new T StageId { get; set; } = default!;

        [JsonProperty("tournament_id")] public new T TournamentId { get; set; } = default!;
    }
    
    public class RequestParameters<T, TT> : RequestParameters<T>
    {
        public new TT Status { get; set; } = default!;
    }
}