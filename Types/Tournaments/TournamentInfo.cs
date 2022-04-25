namespace WorldOfTanksBlitz.Types.Tournaments
{
    public struct TournamentInfo
    {
        public string title { get; set; }
        public string description { get; set; }
        public string rules { get; set; }
        public string other_rules { get; set; }
        public string prize_description { get; set; }

        public long tournament_id { get; set; }
        public long start_at { get; set; }
        public long end_at { get; set; }
        public long matches_start_at { get; set; }
        public long registration_end_at { get; set; }
        public long registration_start_at { get; set; }

        public byte max_players_count { get; set; }
        public byte min_players_count { get; set; }

        public Logo logo { get; set; }
        public Teams teams { get; set; }
        public Status status { get; set; }
        public Media? media_links { get; set; }

        public Award? fee { get; set; }
        public Award? award { get; set; }
        public Award? winner_award { get; set; }
    }
}