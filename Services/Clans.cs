#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WargamingApi.Types;
using WorldOfTanksBlitz.Types.Clans;
using WorldOfTanksBlitz.Types.Enums;
using TypesClans = System.Collections.Generic.Dictionary<long, WorldOfTanksBlitz.Types.Clans.ClanInfo?>;
using Members = System.Collections.Generic.Dictionary<long, WorldOfTanksBlitz.Types.Clans.MemberInfo?>;
using RequestArguments = WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WorldOfTanksBlitz.Types.RequestParameters;

namespace WorldOfTanksBlitz.Services
{
    public class Clans
    {
        private readonly WorldOfTanksBlitz _client;

        internal Clans(WorldOfTanksBlitz client)
        {
            _client = client;
        }

        public async Task<Respond<Meta, IEnumerable<Clan>>> SearchClans(
            Regions region,
            Language language = Language.En,
            string? search = null,
            IEnumerable<string>? fields = null,
            [Range(1, long.MaxValue)] long? pageNo = 1,
            [Range(1, 100)] byte? limit = null)
        {
            return await _client.GetRequest<Respond<Meta, IEnumerable<Clan>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Clans,
                    Type = Format.List,
                    RequestParameters = new RequestParameters
                    {
                        Search = search,
                        Fields = fields,
                        Language = language,
                        Limit = limit,
                        PageNo = pageNo
                    }
                });
        }

        public async Task<Respond<Meta, TypesClans>> GetClanInfo(
            Regions region,
            Language language = Language.En,
            bool extra = false,
            IEnumerable<long>? clanId = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<Respond<Meta, TypesClans>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Clans,
                    Type = Format.Info,
                    RequestParameters = new RequestParameters
                    {
                        ClanId = clanId,
                        Extra = extra ? new[] {"members"} : null,
                        Language = language,
                        Fields = fields
                    }
                });
        }

        public async Task<Respond<Meta, Members>> GetClanMemberInfo(
            Regions region,
            Language language = Language.En,
            bool extra = false,
            IEnumerable<long>? accountId = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<Respond<Meta, Members>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Clans,
                    Type = Format.AccountInfo,
                    RequestParameters = new RequestParameters
                    {
                        AccountId = accountId,
                        Extra = extra ? new[] {"clan"} : null,
                        Language = language,
                        Fields = fields
                    }
                });
        }
    }
}