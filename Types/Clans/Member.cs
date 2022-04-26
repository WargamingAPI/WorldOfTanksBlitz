using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Clans.Enums;

namespace WorldOfTanksBlitz.Types.Clans
{
    public struct Member
    {
        [JsonProperty("account_name")] public string AccountName { get; set; }

        [JsonProperty("joined_at")] public long JoinedAt { get; set; }
        [JsonProperty("account_id")] public long AccountId { get; set; }

        public ClansRoles Role { get; set; }
    }
}