using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WorldOfTanksBlitz.Services;
using WorldOfTanksBlitz.Types;
using WorldOfTanksBlitz.Types.Enums;

namespace WorldOfTanksBlitz
{
    public sealed class WorldOfTanksBlitz
    {
        private readonly string _requestForm;

        public WorldOfTanksBlitz(string applicationId)
        {
            /*
             * 0 - Region
             * 1 - Section
             * 2 - Type
             * 3 - Parameters
             */
            _requestForm =
                @"https://api.wotblitz.{0}/wotb/{1}/{2}/?application_id="
                + applicationId
                + "{3}";
        }

        public ServiceProvider Services { get; private set; } = null!;

        public ServiceProvider InitServices(Service services)
        {
            if (services == Service.None)
                return Services;

            IServiceCollection svc = new ServiceCollection();

            if (services.HasService(Service.Accounts))
                svc = svc.AddSingleton(new Accounts(this));
            if (services.HasService(Service.Clans))
                svc = svc.AddSingleton(new Clans(this));
            if (services.HasService(Service.Encyclopedia))
                svc = svc.AddSingleton(new Encyclopedia(this));
            if (services.HasService(Service.PlayerVehicles))
                svc = svc.AddSingleton(new PlayerVehicles(this));
            if (services.HasService(Service.Tournaments))
                svc = svc.AddSingleton(new Tournaments(this));

            Services = svc.BuildServiceProvider();
            return Services;
        }

        internal async Task<T> GetRequest<T>(RequestArguments requestArguments)
        {
            return await WargamingApi.WargamingApi.GetRequest<T>(
                new Uri(
                    string.Format(
                        _requestForm,
                        nameof(requestArguments.Region).ToLower(),
                        nameof(requestArguments.Section).ToLower(),
                        nameof(requestArguments.Type).ToLower(),
                        requestArguments.Parameters
                    )
                )
            );
        }
    }
}