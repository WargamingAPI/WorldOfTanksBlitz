using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SmartFormat;
using WorldOfTanksBlitz.Services;
using WorldOfTanksBlitz.Types;

namespace WorldOfTanksBlitz
{
    public sealed class WorldOfTanksBlitz
    {
        private readonly string _requestForm;

        public WorldOfTanksBlitz(string applicationId)
        {
            _requestForm =
                @"https://api.wotblitz.{Region}/wotb/{Section}/{Type}/?application_id="
                + applicationId
                + "{Parameters}";
        }

        public ServiceProvider Services { get; private set; } = null!;

        public ServiceProvider InitServices(Service services)
        {
            if (services == Service.None)
                return Services;

            IServiceCollection svc = new ServiceCollection(); //.AddSingleton(this);

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
                new Uri(Smart.Format(_requestForm, requestArguments))
            );
        }
    }
}
