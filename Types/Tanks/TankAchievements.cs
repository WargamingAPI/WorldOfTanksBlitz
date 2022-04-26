using WorldOfTanksBlitz.Types.Achievements;
using MaxSeriesList = System.Collections.Generic.Dictionary<string, uint>;
using AchievementsList = System.Collections.Generic.Dictionary<string, uint>;

namespace WorldOfTanksBlitz.Types.Tanks
{
    public class TankAchievements : UserAchievements
    {
        public long account_id { get; set; }
        public long tank_id { get; set; }

        [JsonProperty("tank_id")] public long TankId { get; set; }
    }
}