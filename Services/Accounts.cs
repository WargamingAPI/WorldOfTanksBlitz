#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using WargamingApi.Types;
using WargamingApi.Types.Enums;
using WargamingApi.WorldOfTanksBlitz.Types;
using WargamingApi.WorldOfTanksBlitz.Types.Accounts;
using WargamingApi.WorldOfTanksBlitz.Types.Achievements;
using WargamingApi.WorldOfTanksBlitz.Types.Enums;
using WargamingApi.WorldOfTanksBlitz.Types.Tanks;
using RequestArguments = WargamingApi.WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WargamingApi.WorldOfTanksBlitz.Types.RequestParameters;

namespace WargamingApi.WorldOfTanksBlitz.Services
{
    public sealed class Accounts
    {
        private readonly WorldOfTanksBlitzClient m_client;

        public Accounts(WorldOfTanksBlitzClient client)
        {
            m_client = client;
        }

        public async Task<Respond<Meta, IEnumerable<Account>>> SearchAccounts(
            Regions region,
            string search,
            Language language = Language.En,
            IEnumerable<string>? fields = null,
            byte? limit = null,
            Type? type = Type.StartsWith)
        {
            return await m_client.GetRequest<Respond<Meta, IEnumerable<Account>>>(
                new Types.RequestArguments
                {
                    Region = region,
                    Section = Sections.Account,
                    Type = Format.List,
                    RequestParameters = new Types.RequestParameters
                    {
                        Search = search,
                        Fields = fields,
                        Language = language,
                        Limit = limit,
                        Type = type
                    }
                });
        }

        public async Task<Respond<Meta, Dictionary<long, AccountInfo?>>> GetAccountInfo(
            Regions region,
            IEnumerable<long> accountId,
            Language language = Language.En,
            string? accessToken = null,
            IEnumerable<string>? extra = null,
            IEnumerable<string>? fields = null)
        {
            return await m_client.GetRequest<Respond<Meta, Dictionary<long, AccountInfo?>>>(new Types.RequestArguments
            {
                Region = region,
                Section = Sections.Account,
                Type = Format.Info,
                RequestParameters = new Types.RequestParameters
                {
                    AccountId = accountId,
                    AccessToken = accessToken,
                    Fields = fields,
                    Language = language,
                    Extra = extra
                }
            });
        }

        public async Task<UserAchievements> GetAchievements(
            Regions region,
            IEnumerable<long> accountId,
            Language language = Language.En,
            IEnumerable<string>? fields = null)
        {
            return await m_client.GetRequest<UserAchievements>(new Types.RequestArguments
            {
                Region = region,
                Section = Sections.Account,
                Type = Format.Achievements,
                RequestParameters = new Types.RequestParameters
                {
                    AccountId = accountId,
                    Fields = fields,
                    Language = language
                }
            });
        }

        public async Task<TankStats> GetTankStats(
            Regions region,
            IEnumerable<long> accountId,
            long tankId,
            IEnumerable<string>? fields = null,
            Language? language = Language.En)
        {
            return await m_client.GetRequest<TankStats>(new Types.RequestArguments
            {
                Region = region,
                Section = Sections.Account,
                Type = Format.TankStats,
                RequestParameters = new RequestParameters<long?, string>
                {
                    AccountId = accountId,
                    Fields = fields,
                    Language = language,
                    TankId = tankId
                }
            });
        }
    }
}