using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WargamingApi.WorldOfTanksBlitz.Types.Clans.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecruitingPolicy : byte
    {
        None,
        Open,
        Close
    }
}