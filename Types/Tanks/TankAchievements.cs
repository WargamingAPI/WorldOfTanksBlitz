using Newtonsoft.Json;
using WargamingApi.WorldOfTanksBlitz.Types.Achievements;
using MaxSeriesList = System.Collections.Generic.Dictionary<string, uint>;
using AchievementsList = System.Collections.Generic.Dictionary<string, uint>;

namespace WargamingApi.WorldOfTanksBlitz.Types.Tanks
{
    public class TankAchievements : UserAchievements
    {
        [JsonProperty("account_id")] public long AccountId { get; set; }

        [JsonProperty("tank_id")] public long TankId { get; set; }
    }
}