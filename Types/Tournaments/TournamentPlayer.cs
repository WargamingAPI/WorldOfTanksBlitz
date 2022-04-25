#nullable enable
namespace WorldOfTanksBlitz.Types.Tournaments
{
    public class TournamentPlayer
    {
        public long account_id { get; set; }
        public string? image { get; set; } = null;
        public string name { get; set; } = "";
        public string? role { get; set; } = null;
    }
}