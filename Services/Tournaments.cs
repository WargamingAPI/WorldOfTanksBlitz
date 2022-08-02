#nullable enable
using System.Collections.Generic;
using System.Threading.Tasks;
using WargamingApi.Types;
using WargamingApi.Types.Enums;
using WargamingApi.WorldOfTanksBlitz.Types;
using WargamingApi.WorldOfTanksBlitz.Types.Enums;
using WargamingApi.WorldOfTanksBlitz.Types.Tournaments;
using WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Enums;
using WargamingApi.WorldOfTanksBlitz.Types.Tournaments.Structs;
using RequestArguments = WargamingApi.WorldOfTanksBlitz.Types.RequestArguments;
using RequestParameters = WargamingApi.WorldOfTanksBlitz.Types.RequestParameters;

namespace WargamingApi.WorldOfTanksBlitz.Services
{
    public class Tournaments
    {
        private readonly WorldOfTanksBlitzClient m_client;

        public Tournaments(WorldOfTanksBlitzClient client)
        {
            m_client = client;
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
            return await m_client.GetRequest<IEnumerable<Tournament>>(
                new Types.RequestArguments
                {
                    Region = region,
                    Section = Sections.Tournaments,
                    Type = Format.List,
                    RequestParameters = new Types.RequestParameters
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
            return await m_client.GetRequest<Respond<Meta, Dictionary<long, TournamentInfo>>>(
                new Types.RequestArguments
                {
                    Region = region,
                    Section = Sections.Tournaments,
                    Type = Format.Info,
                    RequestParameters = new Types.RequestParameters
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
            return await m_client.GetRequest<Respond<Meta, Dictionary<long, TournamentInfo>>>(
                new Types.RequestArguments
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
        
        public async Task<Respond<Meta, IEnumerable<TournamentStage>>> GetTournamentStages(
            Regions region,
            long tournamentId,
            Language language = Language.En,
            byte? limit = null,
            byte? pageNo = null,
            IEnumerable<string>? fields = null)
        {
            return await m_client.GetRequest<Respond<Meta, IEnumerable<TournamentStage>>>(
                new Types.RequestArguments
                {
                    Region = region,
                    Section = Sections.Tournaments,
                    Type = Format.Stages,
                    RequestParameters = new RequestParameters<long?>
                    {
                        Language = language,
                        Fields = fields,
                        TournamentId = tournamentId,
                        Limit = limit,
                        PageNo = pageNo
                    }
                });
        }
        
        public async Task<Respond<Meta, IEnumerable<Match>>> GetTournamentMatches(
            Regions region,
            long stageId,
            long tournamentId,
            Language language = Language.En,
            byte? limit = null,
            byte? pageNo = null,
            IEnumerable<long>? groupId = null,
            IEnumerable<long>? roundNumber = null,
            IEnumerable<long>? teamId = null,
            IEnumerable<string>? fields = null)
        {
            return await m_client.GetRequest<Respond<Meta, IEnumerable<Match>>>(
                new Types.RequestArguments
                {
                    Region = region,
                    Section = Sections.Tournaments,
                    Type = Format.Matches,
                    RequestParameters = new RequestParameters<long?>
                    {
                        Language = language,
                        Fields = fields,
                        TournamentId = tournamentId,
                        StageId = stageId,
                        Limit = limit,
                        PageNo = pageNo
                    }
                });
        }
    }
}