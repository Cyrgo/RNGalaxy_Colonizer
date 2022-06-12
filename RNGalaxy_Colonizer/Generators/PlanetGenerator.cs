using RNGalaxy_Colonizer.Models.CelestialBodies.Planets;
using RNGalaxy_Colonizer.Models.Enums.PlanetTypes;

namespace RNGalaxy_Colonizer.Generators;

public static class PlanetGenerator {

    #region Random Type Generator Methods

    private static GiantPlanetType GenerateGiantPlanetType() {
        var giantPlanetTypes = new List<GiantPlanetType> {
            GiantPlanetType.BrownDwarf, GiantPlanetType.ChtonianPlanet, GiantPlanetType.EccentricJupiter,
            GiantPlanetType.GasGiant, GiantPlanetType.GiantPlanet, GiantPlanetType.HeliumPlanet,
            GiantPlanetType.HotJupiter, GiantPlanetType.HotNeptune, GiantPlanetType.IceGiant,
            GiantPlanetType.MiniNeptune, GiantPlanetType.PuffyPlanet, GiantPlanetType.SuperJupiter
        };

        var random = new Random();
        var randGiantPlanetTypeIndex = random.Next(giantPlanetTypes.Count);
        var randGiantPlanetType = giantPlanetTypes[randGiantPlanetTypeIndex];
        return randGiantPlanetType;
    }

    private static OtherPlanetType GenerateOtherPlanetType() {
        var otherPlanetTypes = new List<OtherPlanetType> {
            OtherPlanetType.Blanet, OtherPlanetType.CircumbinaryPlanet, OtherPlanetType.CircumternaryPlanet,
            OtherPlanetType.CorelessPlanet, OtherPlanetType.DoublePlanet, OtherPlanetType.DisruptedPlanet,
            OtherPlanetType.ExtraGalacticPlanet, OtherPlanetType.ExtraSolarPlanet, OtherPlanetType.PulsarPlanet,
            OtherPlanetType.RoguePlanet, OtherPlanetType.TrojanPlanet
        };

        var random = new Random();
        var randOtherPlanetTypeIndex = random.Next(otherPlanetTypes.Count);
        var randOtherPlanetType = otherPlanetTypes[randOtherPlanetTypeIndex];
        return randOtherPlanetType;
    }

    private static TerrestrialPlanetType GenerateTerrestrialPlanetType() {
        var terrestrialPlanetTypes = new List<TerrestrialPlanetType> {
            TerrestrialPlanetType.AmmoniaPlanet, TerrestrialPlanetType.BarrenPlanet, TerrestrialPlanetType.CarbonPlanet,
            TerrestrialPlanetType.CityPlanet, TerrestrialPlanetType.ChlorinePlanet, TerrestrialPlanetType.DesertPlanet,
            TerrestrialPlanetType.DonutPlanet, TerrestrialPlanetType.DwarfPlanet, TerrestrialPlanetType.EarthAnalog,
            TerrestrialPlanetType.EyeballPlanet, TerrestrialPlanetType.ForestPlanet, TerrestrialPlanetType.IcePlanet,
            TerrestrialPlanetType.IronPlanet, TerrestrialPlanetType.LavaPlanet, TerrestrialPlanetType.MegaEarth,
            TerrestrialPlanetType.MesoPlanet, TerrestrialPlanetType.OceanPlanet, TerrestrialPlanetType.Planemo,
            TerrestrialPlanetType.ProtoPlanet, TerrestrialPlanetType.SnowPlanet, TerrestrialPlanetType.SubEarth,
            TerrestrialPlanetType.SuperEarth, TerrestrialPlanetType.SuperHabitablePlanet, TerrestrialPlanetType.TerrestrialPlanet
        };

        var random = new Random();
        var randTerrestrialPlanetTypeIndex = random.Next(terrestrialPlanetTypes.Count);
        var randTerrestrialPlanetType = terrestrialPlanetTypes[randTerrestrialPlanetTypeIndex];
        return randTerrestrialPlanetType;
    }

    public static Planet Generate() {
        var random = new Random();
        var randInt = random.Next(1, 3);
        Planet randomPlanet = randInt switch {
            1 => new GiantPlanet(GenerateGiantPlanetType(), "Giant Planet"),
            2 => new OtherPlanet(GenerateOtherPlanetType(), "Other Planet"),
            3 => new TerrestrialPlanet(GenerateTerrestrialPlanetType(), "Terrestrial Planet"),
            _ => new TerrestrialPlanet(GenerateTerrestrialPlanetType(), "Terrestrial Planet")
        };

        return randomPlanet;
    }

    #endregion

}