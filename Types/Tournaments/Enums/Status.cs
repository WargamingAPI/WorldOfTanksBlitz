using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorldOfTanksBlitz.Types.Tournaments.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status : byte
    {
        None,
        Upcoming,

        [EnumMember(Value = "registration_started")]
        RegistrationStarted,

        [EnumMember(Value = "registration_finished")]
        RegistrationFinished,

        Running,
        Finished,
        Complete
    }
}