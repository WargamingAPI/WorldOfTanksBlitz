#nullable enable
using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Structs
{
    public struct Player
    {
        [JsonProperty("account_id")] public long AccountId;

        public string? Image;
        public string Name;
        public string? Role;
    }
}