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
            Language language = Language.en,
            IEnumerable<string>? fields = null,
            [Range(1, 100)] byte? limit = null,
            WargamingApi.Types.Types? type = WargamingApi.Types.Types.startswith)
        {
            return await _client.GetRequest<Respond<Meta, IEnumerable<Account>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.account,
                    Type = Format.list,
                    RequestParameters = new RequestParameters
                    {
                        search = search,
                        fields = fields,
                        language = language,
                        limit = limit,
                        type = type
                    }
                });
        }

        public async Task<Respond<Meta, Dictionary<long, AccountInfo?>>> GetAccountInfo(
            Regions region,
            IEnumerable<long> accountId,
            Language language = Language.en,
            string? accessToken = null,
            IEnumerable<string>? extra = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<long, AccountInfo?>>>(new RequestArguments
            {
                Region = region,
                Section = Sections.account,
                Type = Format.info,
                RequestParameters = new RequestParameters
                {
                    account_id = accountId,
                    access_token = accessToken,
                    fields = fields,
                    language = language,
                    extra = extra
                }
            });
        }

        public async Task<Achievements> GetAchievements(
            Regions region,
            IEnumerable<long> accountId,
            Language language = Language.en,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<Achievements>(new RequestArguments
            {
                Region = region,
                Section = Sections.account,
                Type = Format.achievements,
                RequestParameters = new RequestParameters
                {
                    account_id = accountId,
                    fields = fields,
                    language = language
                }
            });
        }

        public async Task<TankStats> GetTankStats(
            Regions region,
            IEnumerable<long> accountId,
            long tankId,
            IEnumerable<string>? fields = null,
            Language? language = Language.en)
        {
            return await _client.GetRequest<TankStats>(new RequestArguments
            {
                Region = region,
                Section = Sections.account,
                Type = Format.tankstats,
                RequestParameters = new RequestParameters<long?, string>
                {
                    account_id = accountId,
                    fields = fields,
                    language = language,
                    tank_id = tankId
                }
            });
        }
    }
}