#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WargamingApi.Types;
using WorldOfTanksBlitz.Types;
using WorldOfTanksBlitz.Types.Clans;
using RequestArguments = WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WorldOfTanksBlitz.Types.RequestParameters;
using TypesClans = System.Collections.Generic.Dictionary<long, WorldOfTanksBlitz.Types.Clans.ClanInfo?>;
using Members = System.Collections.Generic.Dictionary<long, WorldOfTanksBlitz.Types.Clans.MemberInfo?>;

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
            Language language = Language.en,
            string? search = null,
            IEnumerable<string>? fields = null,
            [Range(1, long.MaxValue)] long? pageNo = 1,
            [Range(1, 100)] byte? limit = null)
        {
            return await _client.GetRequest<Respond<Meta, IEnumerable<Clan>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.clans,
                    Type = Format.list,
                    RequestParameters = new RequestParameters
                    {
                        search = search,
                        fields = fields,
                        language = language,
                        limit = limit,
                        page_no = pageNo
                    }
                });
        }

        public async Task<Respond<Meta, TypesClans>> GetClanInfo(
            Regions region,
            Language language = Language.en,
            bool extra = false,
            IEnumerable<long>? clanId = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<Respond<Meta, TypesClans>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.clans,
                    Type = Format.info,
                    RequestParameters = new RequestParameters
                    {
                        clan_id = clanId,
                        extra = extra ? new[] {"members"} : null,
                        language = language,
                        fields = fields
                    }
                });
        }

        public async Task<Respond<Meta, Members>> GetClanMemberInfo(
            Regions region,
            Language language = Language.en,
            bool extra = false,
            IEnumerable<long>? accountId = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<Respond<Meta, Members>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.clans,
                    Type = Format.accountinfo,
                    RequestParameters = new RequestParameters
                    {
                        account_id = accountId,
                        extra = extra ? new[] {"clan"} : null,
                        language = language,
                        fields = fields
                    }
                });
        }
    }
}