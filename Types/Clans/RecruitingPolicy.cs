using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorldOfTanksBlitz.Types.Clans
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecruitingPolicy : byte
    {
        None,
        open,
        close
    }
}