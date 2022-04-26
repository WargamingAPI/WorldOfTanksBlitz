using WorldOfTanksBlitz.Types.Tanks.Enums;

namespace WorldOfTanksBlitz.Types.Tanks
{
    public class TankInfo : TankStats
    {
        public bool? in_garage { get; set; }
        public long? in_garage_updated { get; set; }

        [JsonProperty("in_garage_updated")] public long? InGarageUpdated { get; set; }
    }
}