using RNGalaxy_Colonizer.Models.Enums.PlanetTypes;

namespace RNGalaxy_Colonizer.Models.CelestialBodies.Planets;

public class OtherPlanet : Planet {
    private OtherPlanetType OtherPlanetType { get; }

    private string OtherTypeName => GetOtherTypeName(this.OtherPlanetType);

    public OtherPlanet(OtherPlanetType otherPlanetType, string name) : base(name) {
        this.OtherPlanetType = otherPlanetType;
        this.Name = name;
        this.Type = this.OtherTypeName;
    }

    private static string GetOtherTypeName(OtherPlanetType otherPlanetType) {
        var planetTypeName = otherPlanetType switch {
            OtherPlanetType.Blanet => "Blanet",
            OtherPlanetType.CircumbinaryPlanet => "Circumbinary",
            OtherPlanetType.CircumternaryPlanet => "Circumternary",
            OtherPlanetType.CorelessPlanet => "Coreless",
            OtherPlanetType.DisruptedPlanet => "Disrupted",
            OtherPlanetType.ExtraGalacticPlanet => "Extra Galactic",
            OtherPlanetType.ExtraSolarPlanet => "Extra Solar",
            OtherPlanetType.PulsarPlanet => "Pulsar",
            OtherPlanetType.RoguePlanet => "Rogue",
            OtherPlanetType.TrojanPlanet => "Trojan",
            _ => ""
        };
        return planetTypeName;
    }
}