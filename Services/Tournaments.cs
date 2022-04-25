#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WargamingApi.Types;
using WorldOfTanksBlitz.Types;
using WorldOfTanksBlitz.Types.Tournaments;
using WorldOfTanksBlitz.Types.Tournaments.Enums;
using RequestArguments = WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WorldOfTanksBlitz.Types.RequestParameters;

namespace WorldOfTanksBlitz.Services
{
    public class Tournaments
    {
        private readonly WorldOfTanksBlitz _client;

        internal Tournaments(WorldOfTanksBlitz client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Tournament>> GetTournamentsList(
            Regions region,
            Language language = Language.en,
            Status status = Status.None,
            string? search = null,
            [Range(1, 100)] byte? limit = null,
            long? pageNo = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<IEnumerable<Tournament>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.tournaments,
                    Type = Format.list,
                    RequestParameters = new RequestParameters
                    {
                        language = language,
                        status = status != Status.None ? status.ToString() : null,
                        search = search,
                        limit = limit,
                        page_no = pageNo,
                        fields = fields
                    }
                });
        }

        public async Task<Respond<Meta, Dictionary<long, TournamentInfo>>> GetTournamentInfo(
            Regions region,
            Language language = Language.en,
            IEnumerable<long>? tournamentId = null,
            IEnumerable<string>? fields = null)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<long, TournamentInfo>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.tournaments,
                    Type = Format.info,
                    RequestParameters = new RequestParameters
                    {
                        language = language,
                        fields = fields,
                        tournament_id = tournamentId
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
            Language language = Language.en)
        {
            return await _client.GetRequest<Respond<Meta, Dictionary<long, TournamentInfo>>>(
                new RequestArguments
                {
                    Region = region,
                    Section = Sections.tournaments,
                    Type = Format.teams,
                    RequestParameters = new RequestParameters<long?, IEnumerable<TeamStatus>?>
                    {
                        language = language,
                        fields = fields,
                        tournament_id = tournamentId,
                        account_id = accountId,
                        team_id = teamId,
                        status = status,
                        clan_id = clanId,
                        limit = limit,
                        page_no = pageNo,
                        search = search
                    }
                });
        }
    }
}