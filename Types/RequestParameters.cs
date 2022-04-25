#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types
{
    public class RequestParameters : WargamingApi.Types.RequestParameters
    {
        public string? status { get; set; }

        public long? page_no { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<string>? extra { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? tank_id { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? tournament_id { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? clan_id { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long>? team_id { get; set; }

        [JsonConverter(typeof(ByteConverter))] public bool? in_garage { get; set; }
    }

    public class RequestParameters<T, TT> : RequestParameters
    {
        public new T tank_id { get; set; } = default!;
        public new T tournament_id { get; set; } = default!;

        [JsonConverter(typeof(ArrayConverter))]
        public new TT status { get; set; } = default!;
    }
}