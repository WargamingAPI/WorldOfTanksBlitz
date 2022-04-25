namespace WorldOfTanksBlitz.Types.Accounts
{
    public struct AccountInfo
    {
        public long account_id { get; set; }
        public string nickname { get; set; }

        //TODO: add private fields
        /*
         private		                                Приватные данные игрока
         private.free_xp	            numeric	        Количество свободного опыта
         private.gold	                numeric	        Текущий баланс золота
         private.premium_expires_at	    timestamp	    Срок действия премиум аккаунта
         */
    }
}