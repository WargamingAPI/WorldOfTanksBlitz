#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using WargamingApi.WorldOfTanksBlitz.Types.Clans.Enums;

namespace WargamingApi.WorldOfTanksBlitz.Types.Clans
{
    public class ClanInfo : Clan
    {
        [JsonProperty("is_clan_disbanded")] public bool IsClanDisbanded { get; set; }

        [JsonProperty("creator_id")] public long CreatorId { get; set; }
        [JsonProperty("leader_id")] public long LeaderId { get; set; }
        [JsonProperty("renamed_at")] public long? RenamedAt { get; set; }
        [JsonProperty("emblem_set_id")] public long EmblemSetId { get; set; }
        [JsonProperty("old_tag")] public string? OldTag { get; set; }

        [JsonProperty("old_name")] public string? OldName { get; set; }
        public string Description { get; set; } = "";
        public string Motto { get; set; } = "";

        [JsonProperty("creator_name")] public string CreatorName { get; set; } = "";

        [JsonProperty("leader_name")] public string LeaderName { get; set; } = "";

        [JsonProperty("recruiting_options")] public RecruitingOptions? RecruitingOptions { get; set; }
        public Dictionary<long, Member?>? Members { get; set; }

        [JsonProperty("recruiting_policy")] public RecruitingPolicy RecruitingPolicy { get; set; }

        [JsonProperty("members_ids")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long> MembersIds { get; set; } = Array.Empty<long>();
    }
}