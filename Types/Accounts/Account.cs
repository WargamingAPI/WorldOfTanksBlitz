using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Accounts
{
    public class Account
    {
        [JsonProperty("account_id")] public long AccountId { get; set; }
        public string Nickname { get; set; }

        public override string ToString()
        {
            return $"{nameof(Account)}: {{{nameof(AccountId)}: {AccountId.ToString()}, {nameof(Nickname)}: {Nickname}}}";
        }
    }
}