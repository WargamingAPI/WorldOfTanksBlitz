namespace WargamingApi.WorldOfTanksBlitz.Types.Enums
{
    public enum Format : byte
    {
        // Account, Encyclopedia, Clans, PlayerVehicles, Tournaments
        List,
        Info,
        Achievements,
        TankStats,

        // PlayerVehicles
        Stats,

        // Clans
        AccountInfo,
        //glossary,

        // Tournaments
        Teams,
        Stages,
        Matches,
        Standings,
        Tables,

        // Encyclopedia
        Vehicles,
        VehicleProfile,
        Modules,
        Provisions,
        CrewSkills,
        VehicleProfiles
    }
}