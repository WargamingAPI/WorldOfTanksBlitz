using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Accounts
{
    public class Account
    {
        [JsonProperty("account_id")] public long AccountId { get; set; }

        public string Nickname { get; set; }
    }
}