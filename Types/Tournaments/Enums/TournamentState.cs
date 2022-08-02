using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TournamentState : byte
    {
        None,

        [EnumMember(Value = "waiting_results")]
        WaitingResults,
        [EnumMember(Value = "got_results")] GotResults,

        Upcoming,
        Canceled
    }
}