using Newtonsoft.Json;
using WorldOfTanksBlitz.Types.Enums;
using static WargamingApi.WargamingApi;

namespace WorldOfTanksBlitz.Types
{
    public class RequestArguments : WargamingApi.Types.RequestArguments
    {
        public Sections Section;
        public Format Type;

        internal new object RequestParameters
        {
            set => base.RequestParameters = JsonConvert.SerializeObject(value, SerializationOptions);
        }
    }
}