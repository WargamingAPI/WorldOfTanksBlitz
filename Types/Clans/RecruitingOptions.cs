namespace WorldOfTanksBlitz.Types.Clans
{
    public struct RecruitingOptions
    {
        public float wins_ratio { get; set; }

        public byte vehicles_level { get; set; }
        public uint battles { get; set; }

        public ushort average_battles_per_day { get; set; }
        public ushort average_damage { get; set; }
    }
}