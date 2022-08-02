using Newtonsoft.Json;
using WargamingApi.WorldOfTanksBlitz.Types.Clans.Enums;

namespace WargamingApi.WorldOfTanksBlitz.Types.Clans
{
    public struct MemberInfo
    {
        [JsonProperty("account_name")] public string AccountName { get; set; }

        [JsonProperty("joined_at")] public long JoinedAt { get; set; }
        [JsonProperty("account_id")] public long AccountId { get; set; }
        [JsonProperty("clan_id")] public long ClanId { get; set; }

        public ClansRoles Role { get; set; }
        public MemberClan? Clan { get; set; }
    }
}