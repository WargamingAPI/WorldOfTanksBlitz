#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WargamingApi.Types;
using WorldOfTanksBlitz.Types;
using WorldOfTanksBlitz.Types.Accounts;
using WorldOfTanksBlitz.Types.Achievements;
using WorldOfTanksBlitz.Types.Enums;
using WorldOfTanksBlitz.Types.Tanks;
using RequestArguments = WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WorldOfTanksBlitz.Types.RequestParameters;

namespace WorldOfTanksBlitz.Services
{
    public sealed class Accounts
    {
        private readonly WorldOfTanksBlitz _client;

        internal Accounts(WorldOfTanksBlitz client)
        {
            _client = client;
        }

        public async Task<Respond<Meta, IEnumerable<Account>>> SearchAccounts(
            Regions region,
            string search,
            Language language = Language.En,
            IEnumerable<string>? fields = null,
            byte? limit = null,
            Type? type = Type.StartsWith)
        {
            return await _client.GetRequest<Respond<Meta, IEnumerable<Account>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Account,
                    Type = Format.List,
                    RequestParameters = new RequestParameters
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
            return await _client.GetRequest<Respond<Meta, Dictionary<long, AccountInfo?>>>(new RequestArguments
            {
                Region = region,
                Section = Sections.Account,
                Type = Format.Info,
                RequestParameters = new RequestParameters
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
            return await _client.GetRequest<UserAchievements>(new RequestArguments
            {
                Region = region,
                Section = Sections.Account,
                Type = Format.Achievements,
                RequestParameters = new RequestParameters
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
            return await _client.GetRequest<TankStats>(new RequestArguments
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