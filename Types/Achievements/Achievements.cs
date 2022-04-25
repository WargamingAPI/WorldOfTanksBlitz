using MaxSeriesList = System.Collections.Generic.Dictionary<string, uint>;
using AchievementsList = System.Collections.Generic.Dictionary<string, uint>;

namespace WorldOfTanksBlitz.Types.Achievements
{
    public struct Achievements
    {
        public AchievementsList achievements { get; set; }
        public MaxSeriesList max_series { get; set; }
    }
}