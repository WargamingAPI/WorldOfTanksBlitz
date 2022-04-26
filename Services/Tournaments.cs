#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using WargamingApi.Types;
using WorldOfTanksBlitz.Types;
using WorldOfTanksBlitz.Types.Enums;
using WorldOfTanksBlitz.Types.Tournaments;
using WorldOfTanksBlitz.Types.Tournaments.Enums;
using RequestArguments = WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WorldOfTanksBlitz.Types.RequestParameters;

namespace WorldOfTanksBlitz.Services
{
    public class Tournaments
    {
        private readonly WorldOfTanksBlitz _client;

        public Tournaments(WorldOfTanksBlitz client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Tournament>> GetTournamentsList(
            Regions region,
            Language language = Language.En,
            Status status = Status.None,
            string? search = null,
            byte? limit = null,
            long? pageNo = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<IEnumerable<Tournament>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Tournaments,
                    Type = Format.List,
                    RequestParameters = new RequestParameters
                    {
                        Language = language,
                        Status = status != Status.None ? status.ToString() : null,
                        Search = search,
                        Limit = limit,
                        PageNo = pageNo,
                        Fields = fields
                    }
                });
        }

        public async Task<Respond<Meta, Dictionary<long, TournamentInfo>>> GetTournamentInfo(
            Regions region,
            Language language = Language.En,
            IEnumerable<long>? tournamentId = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<long, TournamentInfo>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Tournaments,
                    Type = Format.Info,
                    RequestParameters = new RequestParameters
                    {
                        Language = language,
                        Fields = fields,
                        TournamentId = tournamentId
                    }
                });
        }

        public async Task<Respond<Meta, Dictionary<long, TournamentInfo>>> GetTournamentTeams(
            Regions region,
            long tournamentId,
            byte? limit = null,
            long? pageNo = null,
            string? search = null,
            IEnumerable<TeamStatus>? status = null,
            IEnumerable<long>? accountId = null,
            IEnumerable<long>? clanId = null,
            IEnumerable<long>? teamId = null,
            IEnumerable<string>? fields = null,
            Language language = Language.En)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<long, TournamentInfo>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.Tournaments,
                    Type = Format.Teams,
                    RequestParameters = new RequestParameters<long?, IEnumerable<TeamStatus>?>
                    {
                        Language = language,
                        Fields = fields,
                        TournamentId = tournamentId,
                        AccountId = accountId,
                        TeamId = teamId,
                        Status = status,
                        ClanId = clanId,
                        Limit = limit,
                        PageNo = pageNo,
                        Search = search
                    }
                });
        }
    }
}