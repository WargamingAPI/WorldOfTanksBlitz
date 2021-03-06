using Newtonsoft.Json;
using MaxSeriesList = System.Collections.Generic.Dictionary<string, uint>;
using AchievementsList = System.Collections.Generic.Dictionary<string, uint>;

namespace WorldOfTanksBlitz.Types.Achievements
{
    public class UserAchievements
    {
        public AchievementsList Achievements { get; set; }

        [JsonProperty("max_series")] public MaxSeriesList MaxSeries { get; set; }
    }
}