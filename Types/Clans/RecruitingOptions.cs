using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Clans
{
    public struct RecruitingOptions
    {
        [JsonProperty("wins_ratio")] public float WinsRatio { get; set; }

        [JsonProperty("vehicles_level")] public byte VehiclesLevel { get; set; }
        public uint Battles { get; set; }

        [JsonProperty("average_battles_per_day")]
        public ushort AverageBattlesPerDay { get; set; }

        [JsonProperty("average_damage")] public ushort AverageDamage { get; set; }
    }
}