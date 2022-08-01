using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Tournaments.Structs
{
    public struct Group
    {
        [JsonProperty("group_id")] public long GroupId;
        [JsonProperty("group_order")] public long GroupOrder;
    }
}