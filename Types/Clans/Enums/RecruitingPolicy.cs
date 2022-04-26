using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorldOfTanksBlitz.Types.Clans.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecruitingPolicy : byte
    {
        None,
        Open,
        Close
    }
}