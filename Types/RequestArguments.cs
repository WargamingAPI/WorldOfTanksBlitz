using Newtonsoft.Json;
using WargamingApi;
using WorldOfTanksBlitz.Types.Enums;

namespace WorldOfTanksBlitz.Types
{
    public class RequestArguments : WargamingApi.Types.RequestArguments
    {
        public Sections Section;
        public Format Type;

        internal new object RequestParameters
        {
            set => base.RequestParameters = JsonConvert.SerializeObject(value, WargamingApiClient.SerializationOptions);
        }
    }
}