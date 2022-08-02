#nullable enable
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WargamingApi;
using WargamingApi.WorldOfTanksBlitz.Services;
using WargamingApi.WorldOfTanksBlitz.Types;
using WargamingApi.WorldOfTanksBlitz.Types.Enums;
using Extensions = WargamingApi.Types.Extensions;

namespace WargamingApi.WorldOfTanksBlitz
{
    public sealed class WorldOfTanksBlitzClient
    {
        private readonly string m_requestForm;

        public WorldOfTanksBlitzClient(WargamingApiClient client)
        {
            /*
             * 0 - Region
             * 1 - Section
             * 2 - Type
             * 3 - Parameters
             */

            if (string.IsNullOrEmpty(client.ApplicationId) || string.IsNullOrWhiteSpace(client.ApplicationId))
                throw new NullReferenceException(
                    $"Application id can not be null, specify it in {nameof(WargamingApiClient.ApplicationId)} parameter");

            m_requestForm =
                @"https://api.wotblitz.{0}/wotb/{1}/{2}/?application_id="
                + client.ApplicationId
                + "{3}";
        }

        public ServiceProvider Services { get; private set; } = null!;

        public ServiceProvider InitServices(Service services)
        {
            if (services == Service.None)
                return Services;

            var svc = new ServiceCollection().AddSingleton(this);

            if (services.HasService(Service.Accounts))
                svc = svc.AddSingleton<Accounts>();
            if (services.HasService(Service.Clans))
                svc = svc.AddSingleton<Clans>();
            if (services.HasService(Service.Encyclopedia))
                svc = svc.AddSingleton<Encyclopedia>();
            if (services.HasService(Service.PlayerVehicles))
                svc = svc.AddSingleton<PlayerVehicles>();
            if (services.HasService(Service.Tournaments))
                svc = svc.AddSingleton<Tournaments>();

            Services = svc.BuildServiceProvider();
            return Services;
        }

        internal async Task<T> GetRequest<T>(RequestArguments requestArguments)
        {
            var uri = new Uri(
                string.Format(
                    m_requestForm,
                    Extensions.EnumToString(requestArguments.Region).ToLower(),
                    requestArguments.Section.EnumToString().ToLower(),
                    requestArguments.Type.EnumToString().ToLower(),
                    requestArguments.Parameters
                )
            );

            return await WargamingApiClient.GetRequest<T>(uri);
        }
    }
}