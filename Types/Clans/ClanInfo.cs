﻿#nullable enable
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Clans.Enums;

namespace WorldOfTanksBlitz.Types.Clans
{
    public struct ClanInfo
    {
        [JsonProperty("members_count")] public byte MembersCount { get; set; }

        [JsonProperty("is_clan_disbanded")] public bool IsClanDisbanded { get; set; }

        [JsonProperty("clan_id")] public long ClanId { get; set; }
        [JsonProperty("creator_id")] public long CreatorId { get; set; }
        [JsonProperty("leader_id")] public long LeaderId { get; set; }
        [JsonProperty("created_at")] public long CreatedAt { get; set; }
        [JsonProperty("renamed_at")] public long? RenamedAt { get; set; }
        [JsonProperty("emblem_set_id")] public long EmblemSetId { get; set; }

        public string Tag { get; set; }

        [JsonProperty("old_tag")] public string? OldTag { get; set; }
        public string Name { get; set; }

        [JsonProperty("old_name")] public string? OldName { get; set; }
        public string Description { get; set; }
        public string Motto { get; set; }

        [JsonProperty("creator_name")] public string CreatorName { get; set; }

        [JsonProperty("leader_name")] public string LeaderName { get; set; }

        [JsonProperty("recruiting_options")] public RecruitingOptions? RecruitingOptions { get; set; }
        public Dictionary<long, Member?>? Members { get; set; }

        [JsonProperty("recruiting_policy")] public RecruitingPolicy RecruitingPolicy { get; set; }

        [JsonProperty("members_ids")]
        [JsonConverter(typeof(ArrayConverter))]
        public IEnumerable<long> MembersIds { get; set; }
    }
}