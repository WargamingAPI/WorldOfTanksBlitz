using System;

namespace WorldOfTanksBlitz.Types
{
    [Flags]
    public enum Service : byte
    {
        None = 0,
        Accounts = 1 << 0,
        Encyclopedia = 1 << 1,
        Clans = 1 << 2,
        PlayerVehicles = 1 << 3,
        Tournaments = 1 << 4
    }
}