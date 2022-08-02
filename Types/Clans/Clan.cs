using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Clans
{
    public class Clan
    {
        [JsonProperty("members_count")] public byte MembersCount { get; set; }

        public string Tag { get; set; }
        public string Name { get; set; }

        [JsonProperty("clan_id")] public long ClanId { get; set; }

        [JsonProperty("created_at")] public long CreatedAt { get; set; }
    }
}