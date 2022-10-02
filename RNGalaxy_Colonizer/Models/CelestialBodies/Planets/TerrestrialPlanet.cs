using RNGalaxy_Colonizer.Models.Enums.PlanetTypes;

namespace RNGalaxy_Colonizer.Models.CelestialBodies.Planets;

public class TerrestrialPlanet : Planet {
    private TerrestrialPlanetType TerrestrialPlanetType { get; }

    private string TerrestrialTypeName => GetTerrestrialTypeName(this.TerrestrialPlanetType);

    public TerrestrialPlanet(TerrestrialPlanetType terrestrialPlanetType, string name) : base(terrestrialPlanetType, name) {
        this.TerrestrialPlanetType = terrestrialPlanetType;
        this.PlanetType = this.TerrestrialPlanetType;
        this.Name = name;
        this.TypeName = this.TerrestrialTypeName;
    }

    private static string GetTerrestrialTypeName(TerrestrialPlanetType terrestrialPlanetType) {
        var terrestrialTypeName = terrestrialPlanetType switch {
            TerrestrialPlanetType.AmmoniaPlanet => "Ammonia",
            TerrestrialPlanetType.BarrenPlanet => "Barren",
            TerrestrialPlanetType.CarbonPlanet => "Carbon",
            TerrestrialPlanetType.ChlorinePlanet => "Chlorine",
            TerrestrialPlanetType.DesertPlanet => "Desert",
            TerrestrialPlanetType.DonutPlanet => "Donut",
            TerrestrialPlanetType.DwarfPlanet => "Dwarf",
            TerrestrialPlanetType.EarthAnalog => "Earth Analog",
            TerrestrialPlanetType.EyeballPlanet => "Eyeball",
            TerrestrialPlanetType.ForestPlanet => "Forest",
            TerrestrialPlanetType.IcePlanet => "Ice",
            TerrestrialPlanetType.IronPlanet => "Iron",
            TerrestrialPlanetType.LavaPlanet => "Lava",
            TerrestrialPlanetType.MegaEarth => "Mega Earth",
            TerrestrialPlanetType.MesoPlanet => "Meso",
            TerrestrialPlanetType.OceanPlanet => "Ocean",
            TerrestrialPlanetType.Planemo => "Planemo",
            TerrestrialPlanetType.ProtoPlanet => "Proto",
            TerrestrialPlanetType.SnowPlanet => "Snow",
            TerrestrialPlanetType.SubEarth => "Sub Earth",
            TerrestrialPlanetType.SuperEarth => "Super Earth",
            TerrestrialPlanetType.SuperHabitablePlanet => "Super Habitable",
            TerrestrialPlanetType.TerrestrialPlanet => "Terrestrial",
            _ => ""
        };
        return terrestrialTypeName;
    }
}