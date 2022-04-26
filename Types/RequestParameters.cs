#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types
{
    public class RequestParameters : WargamingApi.Types.RequestParameters
    {
        public string? Status { get; set; }

        [JsonProperty("page_no")] public long? PageNo { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? Extra { get; set; }

        [JsonProperty("tank_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? TankId { get; set; }

        [JsonProperty("tournament_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? TournamentId { get; set; }

        [JsonProperty("clan_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? ClanId { get; set; }

        [JsonProperty("team_id")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? TeamId { get; set; }

        [JsonProperty("in_garage")]
        [JsonConverter(typeof(ByteConverter))]
        public bool? InGarage { get; set; }
    }

    public class RequestParameters<T, TT> : RequestParameters
    {
        [JsonProperty("tank_id")] public new T TankId { get; set; } = default!;

        [JsonProperty("tournament_id")] public new T TournamentId { get; set; } = default!;

        [JsonConverter(typeof(ArrayConverter))]
        public new TT Status { get; set; } = default!;
    }
}