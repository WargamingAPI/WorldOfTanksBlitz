namespace WorldOfTanksBlitz.Types.Clans
{
    public struct MemberClan
    {
        public byte members_count { get; set; }

        public string tag { get; set; }
        public string name { get; set; }

        public long clan_id { get; set; }
        public long created_at { get; set; }
        public long emblem_set_id { get; set; }
    }
}