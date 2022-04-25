using WorldOfTanksBlitz.Types.Clans.Enums;

namespace WorldOfTanksBlitz.Types.Clans
{
    public struct Member
    {
        public string account_name { get; set; }

        public long joined_at { get; set; }
        public long account_id { get; set; }

        public ClansRoles role { get; set; }
    }
}