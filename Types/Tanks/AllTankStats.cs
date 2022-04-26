using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Tanks
{
    public struct AllTankStats
    {
        [JsonProperty("max_frags")] public byte MaxFrags { get; set; }

        [JsonProperty("max_xp")] public ushort MaxXp { get; set; }
        [JsonProperty("damage_dealt")] public ushort DamageDealt { get; set; }
        [JsonProperty("damage_received")] public ushort DamageReceived { get; set; }

        public uint Wins { get; set; }
        public uint Losses { get; set; }
        public uint Battles { get; set; }

        [JsonProperty("win_and_survived")] public uint WinAndSurvived { get; set; }
        [JsonProperty("survived_battles")] public uint SurvivedBattles { get; set; }

        public long Xp { get; set; }
        public long Hits { get; set; }
        public long Shots { get; set; }
        public long Frags { get; set; }
        public long Frags8P { get; set; }
        public long Spotted { get; set; }

        [JsonProperty("capture_points")] public long CapturePoints { get; set; }

        [JsonProperty("dropped_capture_points")]
        public long DroppedCapturePoints { get; set; }
    }
}