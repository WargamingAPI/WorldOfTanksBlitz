using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Tanks
{
    public class TankInfo : TankStats
    {
        [JsonProperty("in_garage")] public bool? InGarage { get; set; }

        [JsonProperty("in_garage_updated")] public long? InGarageUpdated { get; set; }
    }
}