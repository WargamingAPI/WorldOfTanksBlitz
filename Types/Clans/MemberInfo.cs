namespace WorldOfTanksBlitz.Types.Clans
{
    public struct MemberInfo
    {
        public string account_name { get; set; }

        public long joined_at { get; set; }
        public long account_id { get; set; }
        public long clan_id { get; set; }

        public ClansRoles role { get; set; }
        public MemberClan? clan { get; set; }
    }
}