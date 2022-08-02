using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WargamingApi.WorldOfTanksBlitz.Types.Accounts
{
    public class AccountInfo : Account
    {
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset CreatedAt { get; set; }
        
        [JsonProperty("last_battle_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset LastBattleTime { get; set; }
        
        [JsonProperty("updated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset UpdatedAt { get; set; }
        
        [JsonProperty("statistics")]
        public Statistics Statistics { get; set; }
        
        //TODO: add private fields
        /*
         private		                                Приватные данные игрока
         private.free_xp	            numeric	        Количество свободного опыта
         private.gold	                numeric	        Текущий баланс золота
         private.premium_expires_at	    timestamp	    Срок действия премиум аккаунта
         */
    }
}