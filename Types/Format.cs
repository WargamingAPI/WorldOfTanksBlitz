namespace WorldOfTanksBlitz.Types
{
    public enum Format : byte
    {
        // Account, Encyclopedia, Clans, PlayerVehicles, Tournaments
        list,
        info,
        achievements,
        tankstats,

        // PlayerVehicles
        stats,

        // Clans
        accountinfo,
        //glossary,

        // Tournaments
        teams,
        stages,
        matches,
        standings,
        tables,

        // Encyclopedia
        vehicles,
        vehicleprofile,
        modules,
        provisions,
        crewskills,
        vehicleprofiles
    }
}