using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WargamingApi.WorldOfTanksBlitz.Types.Accounts
{
    public class Rating
    {
        [JsonProperty("battles")]
        public uint Battles { get; set; }
        
        [JsonProperty("wins")]
        public uint Wins { get; set; }
        
        [JsonProperty("losses")]
        public uint Losses { get; set; }

        public float WinRate => Wins / Battles * 100;
        
        public uint Withdraw => Battles - (Wins + Losses);
        
        [JsonProperty("win_and_survived")]
        public uint WinAndSurvived { get; set; }
        
        [JsonProperty("survived_battles")]
        public uint SurvivedBattles { get; set; }
        
        [JsonProperty("is_recalibration")]
        public bool IsRecalibration { get; set; }
        
        [JsonProperty("recalibration_start_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset RecalibrationStartTime { get; set; }
        
        [JsonProperty("calibration_battles_left")]
        public uint CalibrationBattlesLeft { get; set; }

        [JsonProperty("current_season")]
        public uint CurrentSeason { get; set; }

        [JsonProperty("shots")]
        public uint Shots { get; set; }
        
        [JsonProperty("hits")]
        public uint Hits { get; set; }
        
        public float Accuracy => Hits / Shots * 100;
        
        [JsonProperty("frags")]
        public uint Frags { get; set; }
        
        [JsonProperty("frags8p")]
        public uint Frags8P { get; set; }
        
        [JsonProperty("damage_dealt")]
        public uint DamageDealt { get; set; }
        
        [JsonProperty("damage_received")]
        public uint DamageReceived { get; set; }
        
        [JsonProperty("mm_rating")]
        public float MmRating { get; set; }
        
        [JsonProperty("spotted")]
        public uint Spotted { get; set; }
        
        [JsonProperty("xp")]
        public uint Xp { get; set; }
        
        [JsonProperty("capture_points")]
        public uint CapturePoints { get; set; }
        
        [JsonProperty("dropped_capture_points")]
        public uint DroppedCapturePoints { get; set; }
    }
}