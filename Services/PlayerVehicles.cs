#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using WargamingApi.Types;
using WorldOfTanksBlitz.Types.Enums;
using WorldOfTanksBlitz.Types.Tanks;
using RequestArguments = WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WorldOfTanksBlitz.Types.RequestParameters;

namespace WorldOfTanksBlitz.Services
{
    public class PlayerVehicles
    {
        private readonly WorldOfTanksBlitz _client;

        public PlayerVehicles(WorldOfTanksBlitz client)
        {
            _client = client;
        }

        public async Task<Respond<Meta, Dictionary<string, IEnumerable<TankInfo>?>>> GetTankInfo(
            Regions region,
            long accountId,
            string? accessToken = null,
            bool? inGarage = null,
            IEnumerable<long>? tankId = null,
            IEnumerable<string>? fields = null,
            Language? language = Language.En)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<string, IEnumerable<TankInfo>?>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Tanks,
                    Type = Format.Stats,
                    RequestParameters = new RequestParameters
                    {
                        AccountId = new[] {accountId},
                        InGarage = inGarage,
                        TankId = tankId,
                        AccessToken = accessToken,
                        Fields = fields,
                        Language = language
                    }
                });
        }

        public async Task<Respond<Meta, Dictionary<string, IEnumerable<TankAchievements>?>>> GetTankAchievements(
            Regions region,
            long accountId,
            string? accessToken = null,
            bool? inGarage = null,
            IEnumerable<long>? tankId = null,
            IEnumerable<string>? fields = null,
            Language? language = Language.En)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<string, IEnumerable<TankAchievements>?>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Tanks,
                    Type = Format.Achievements,
                    RequestParameters = new RequestParameters
                    {
                        AccountId = new[] {accountId},
                        InGarage = inGarage,
                        TankId = tankId,
                        AccessToken = accessToken,
                        Fields = fields,
                        Language = language
                    }
                });
        }
    }
}