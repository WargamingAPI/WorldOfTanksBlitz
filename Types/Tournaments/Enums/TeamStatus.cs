using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorldOfTanksBlitz.Types.Tournaments.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TeamStatus : byte
    {
        None,
        Forming,
        Confirmed,
        Disqualified,
        Static
    }
}