using WorldOfTanksBlitz.Types.Tournaments.Enums;

namespace WorldOfTanksBlitz.Types.Tournaments
{
    public struct Tournament
    {
        public string title { get; set; }
        public string description { get; set; }

        public long tournament_id { get; set; }
        public long end_at { get; set; }
        public long matches_start_at { get; set; }
        public long registration_end_at { get; set; }
        public long registration_start_at { get; set; }
        public long start_at { get; set; }

        public Logo logo { get; set; }

        public Award? fee { get; set; }
        public Award? award { get; set; }
        public Award? winner_award { get; set; }

        public Status status { get; set; }
    }
}