using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Accounts
{
    public class All
    {
        [JsonProperty("battles")]
        public uint Battles { get; set; }
        
        [JsonProperty("wins")]
        public uint Wins { get; set; }
        
        [JsonProperty("losses")]
        public uint Losses { get; set; }
        
        public float WinRate => Wins / Battles * 100;
        
        public uint Withdraw => Battles - (Wins + Losses);
        
        [JsonProperty("survived_battles")]
        public uint SurvivedBattles { get; set; }
        
        [JsonProperty("win_and_survived")]
        public uint WinAndSurvived { get; set; }
        
        [JsonProperty("shots")]
        public uint Shots { get; set; }
        
        [JsonProperty("hits")]
        public uint Hits { get; set; }

        public float Accuracy => Hits / Shots * 100;

        [JsonProperty("damage_dealt")]
        public uint DamageDealt { get; set; }
        
        [JsonProperty("damage_received")]
        public uint DamageReceived { get; set; }
        
        [JsonProperty("frags")]
        public uint Frags { get; set; }
        
        [JsonProperty("frags8p")]
        public uint Frags8P { get; set; }
        
        [JsonProperty("max_frags")]
        public uint MaxFrags { get; set; }
        
        [JsonProperty("max_frags_tank_id")]
        public uint MaxFragsTankId { get; set; }
        
        [JsonProperty("capture_points")]
        public uint CapturePoints { get; set; }
        
        [JsonProperty("dropped_capture_points")]
        public uint DroppedCapturePoints { get; set; }
        
        [JsonProperty("xp")]
        public uint Xp { get; set; }
        
        [JsonProperty("max_xp")]
        public uint MaxXp { get; set; }
        
        [JsonProperty("max_xp_tank_id")]
        public uint MaxXpTankId { get; set; }
        
        [JsonProperty("spotted")]
        public uint Spotted { get; set; }
    }
}