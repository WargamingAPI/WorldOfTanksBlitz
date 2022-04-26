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

        internal PlayerVehicles(WorldOfTanksBlitz client)
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
            Language? language = Language.en)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<string, IEnumerable<TankInfo>?>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.tanks,
                    Type = Format.stats,
                    RequestParameters = new RequestParameters
                    {
                        account_id = new[] {accountId},
                        in_garage = inGarage,
                        tank_id = tankId,
                        access_token = accessToken,
                        fields = fields,
                        language = language
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
            Language? language = Language.en)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<string, IEnumerable<TankAchievements>?>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.tanks,
                    Type = Format.achievements,
                    RequestParameters = new RequestParameters
                    {
                        account_id = new[] {accountId},
                        in_garage = inGarage,
                        tank_id = tankId,
                        access_token = accessToken,
                        fields = fields,
                        language = language
                    }
                });
        }
    }
}