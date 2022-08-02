using System;
using System.Runtime.CompilerServices;
using WargamingApi.WorldOfTanksBlitz.Types.Enums;

namespace WargamingApi.WorldOfTanksBlitz.Types
{
    internal static class Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static bool HasService(this Service services, Service target)
        {
            return ((byte) services & (byte) target) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static string EnumToString(this Format target)
        {
            return target switch
            {
                Format.List => nameof(Format.List),
                Format.Info => nameof(Format.Info),
                Format.Achievements => nameof(Format.Achievements),
                Format.TankStats => nameof(Format.TankStats),
                Format.Stats => nameof(Format.Stats),
                Format.AccountInfo => nameof(Format.AccountInfo),
                Format.Teams => nameof(Format.Teams),
                Format.Stages => nameof(Format.Stages),
                Format.Matches => nameof(Format.Matches),
                Format.Standings => nameof(Format.Standings),
                Format.Tables => nameof(Format.Tables),
                Format.Vehicles => nameof(Format.Vehicles),
                Format.VehicleProfile => nameof(Format.VehicleProfile),
                Format.Modules => nameof(Format.Modules),
                Format.Provisions => nameof(Format.Provisions),
                Format.CrewSkills => nameof(Format.CrewSkills),
                Format.VehicleProfiles => nameof(Format.VehicleProfiles),
                _ => throw new ArgumentOutOfRangeException(nameof(target), target, null)
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static string EnumToString(this Sections target)
        {
            return target switch
            {
                Sections.Account => nameof(Sections.Account),
                Sections.Encyclopedia => nameof(Sections.Encyclopedia),
                Sections.Clans => nameof(Sections.Clans),
                Sections.Tanks => nameof(Sections.Tanks),
                Sections.Tournaments => nameof(Sections.Tournaments),
                _ => throw new ArgumentOutOfRangeException(nameof(target), target, null)
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static string EnumToString(this Service target)
        {
            return target switch
            {
                Service.None => nameof(Service.None),
                Service.Accounts => nameof(Service.Accounts),
                Service.Encyclopedia => nameof(Service.Encyclopedia),
                Service.Clans => nameof(Service.Clans),
                Service.PlayerVehicles => nameof(Service.PlayerVehicles),
                Service.Tournaments => nameof(Service.Tournaments),
                _ => throw new ArgumentOutOfRangeException(nameof(target), target, null)
            };
        }
    }
}