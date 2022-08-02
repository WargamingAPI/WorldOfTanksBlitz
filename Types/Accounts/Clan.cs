using Newtonsoft.Json;

namespace WargamingApi.WorldOfTanksBlitz.Types.Accounts
{
    public class Clan
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
        
        [JsonProperty("frags")]
        public long Frags { get; set; }
        
        [JsonProperty("frags8p")]
        public long Frags8P { get; set; }
        
        [JsonProperty("max_frags")]
        public byte MaxFrags { get; set; }
        
        [JsonProperty("max_frags_tank_id")]
        public long MaxFragsTankId { get; set; }
        
        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; set; }
        
        [JsonProperty("damage_received")]
        public long DamageReceived { get; set; }
        
        [JsonProperty("xp")]
        public uint Xp { get; set; }
        
        [JsonProperty("max_xp")]
        public ushort MaxXp { get; set; }
        
        [JsonProperty("max_xp_tank_id")]
        public long MaxXpTankId { get; set; }
        
        [JsonProperty("spotted")]
        public uint Spotted { get; set; }
        
        [JsonProperty("capture_points")]
        public uint CapturePoints { get; set; }
        
        [JsonProperty("dropped_capture_points")]
        public uint DroppedCapturePoints { get; set; }
    }
}