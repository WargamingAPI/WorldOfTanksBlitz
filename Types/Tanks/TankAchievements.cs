using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Achievements;
using MaxSeriesList = System.Collections.Generic.Dictionary<string, uint>;
using AchievementsList = System.Collections.Generic.Dictionary<string, uint>;

namespace WorldOfTanksBlitz.Types.Tanks
{
    public class TankAchievements : UserAchievements
    {
        [JsonProperty("account_id")] public long AccountId { get; set; }

        [JsonProperty("tank_id")] public long TankId { get; set; }
    }
}