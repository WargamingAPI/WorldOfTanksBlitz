namespace WorldOfTanksBlitz.Types.Tanks
{
    public struct AllTankStats
    {
        public byte max_frags { get; set; }

        public ushort max_xp { get; set; }
        public ushort damage_dealt { get; set; }
        public ushort damage_received { get; set; }

        public uint wins { get; set; }
        public uint losses { get; set; }
        public uint battles { get; set; }
        public uint win_and_survived { get; set; }
        public uint survived_battles { get; set; }

        public long xp { get; set; }
        public long hits { get; set; }
        public long shots { get; set; }
        public long frags { get; set; }
        public long frags8p { get; set; }
        public long spotted { get; set; }
        public long capture_points { get; set; }
        public long dropped_capture_points { get; set; }
    }
}