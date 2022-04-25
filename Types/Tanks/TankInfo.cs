namespace WorldOfTanksBlitz.Types.Tanks
{
    public struct TankInfo
    {
        public bool? in_garage { get; set; }
        public long? in_garage_updated { get; set; }

        public long tank_id { get; set; }
        public long account_id { get; set; }
        public long battle_life_time { get; set; }
        public long last_battle_time { get; set; }

        public AllTankStats all { get; set; }
        public MarkOfMastery mark_of_mastery { get; set; }
    }
}