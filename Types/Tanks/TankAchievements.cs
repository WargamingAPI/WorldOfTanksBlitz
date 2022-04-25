using WorldOfTanksBlitz.Types.Achievements;
using MaxSeriesList = System.Collections.Generic.Dictionary<string, uint>;
using AchievementsList = System.Collections.Generic.Dictionary<string, uint>;

namespace WorldOfTanksBlitz.Types.Tanks
{
    public struct TankAchievements
    {
        public long account_id { get; set; }
        public long tank_id { get; set; }

        public AchievementsList achievements { get; set; }
        public MaxSeriesList max_series { get; set; }
    }
}