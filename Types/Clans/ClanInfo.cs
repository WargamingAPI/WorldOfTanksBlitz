#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace WorldOfTanksBlitz.Types.Clans
{
    public struct ClanInfo
    {
        public byte members_count { get; set; }

        public bool is_clan_disbanded { get; set; }

        public long clan_id { get; set; }
        public long creator_id { get; set; }
        public long leader_id { get; set; }
        public long created_at { get; set; }
        public long? renamed_at { get; set; }
        public long emblem_set_id { get; set; }

        public string tag { get; set; }
        public string? old_tag { get; set; }
        public string name { get; set; }
        public string? old_name { get; set; }
        public string description { get; set; }
        public string motto { get; set; }
        public string creator_name { get; set; }
        public string leader_name { get; set; }

        public RecruitingOptions? recruiting_options { get; set; }
        public Dictionary<long, Member?>? members { get; set; }

        public RecruitingPolicy recruiting_policy { get; set; }

        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long> members_ids { get; set; }
    }
}