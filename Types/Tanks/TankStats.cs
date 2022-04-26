using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Tanks.Enums;

namespace WorldOfTanksBlitz.Types.Tanks
{
    public class TankStats
    {
        [JsonProperty("tank_id")] public long TankId { get; set; }

        [JsonProperty("account_id")] public long AccountId { get; set; }

        [JsonProperty("battle_life_time")] public long BattleLifeTime { get; set; }

        [JsonProperty("last_battle_time")] public long LastBattleTime { get; set; }

        public AllTankStats All { get; set; }

        [JsonProperty("mark_of_mastery")] public MarkOfMastery MarkOfMastery { get; set; }
    }
}