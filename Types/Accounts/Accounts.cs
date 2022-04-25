using System.Collections.Generic;
using WargamingApi.Types;

namespace WorldOfTanksBlitz.Types.Accounts
{
    public class Accounts : Respond<Meta, Dictionary<long, AccountInfo?>>
    {
    }
}