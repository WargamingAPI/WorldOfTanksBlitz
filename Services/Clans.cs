#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WargamingApi.Types;
using WargamingApi.Types.Enums;
using WargamingApi.WorldOfTanksBlitz.Types.Clans;
using WargamingApi.WorldOfTanksBlitz.Types.Enums;
using TypesClans = System.Collections.Generic.Dictionary<long, WargamingApi.WorldOfTanksBlitz.Types.Clans.ClanInfo?>;
using Members = System.Collections.Generic.Dictionary<long, WargamingApi.WorldOfTanksBlitz.Types.Clans.MemberInfo?>;
using RequestArguments = WargamingApi.WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WargamingApi.WorldOfTanksBlitz.Types.RequestParameters;

namespace WargamingApi.WorldOfTanksBlitz.Services
{
    public class Clans
    {
        private readonly WorldOfTanksBlitzClient m_client;

        public Clans(WorldOfTanksBlitzClient client)
        {
            m_client = client;
        }

        public async Task<Respond<Meta, IEnumerable<Clan>>> SearchClans(
            Regions region,
            Language language = Language.En,
            string? search = null,
            IEnumerable<string>? fields = null,
            [Range(1, long.MaxValue)] long? pageNo = 1,
            [Range(1, 100)] byte? limit = null)
        {
            return await m_client.GetRequest<Respond<Meta, IEnumerable<Clan>>>(
                new Types.RequestArguments
                {
                    Region = region,
                    Section = Sections.Clans,
                    Type = Format.List,
                    RequestParameters = new Types.RequestParameters
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
            return await m_client.GetRequest<Respond<Meta, TypesClans>>(
                new Types.RequestArguments
                {
                    Region = region,
                    Section = Sections.Clans,
                    Type = Format.Info,
                    RequestParameters = new Types.RequestParameters
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
            return await m_client.GetRequest<Respond<Meta, Members>>(
                new Types.RequestArguments
                {
                    Region = region,
                    Section = Sections.Clans,
                    Type = Format.AccountInfo,
                    RequestParameters = new Types.RequestParameters
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