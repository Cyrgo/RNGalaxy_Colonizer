using RNGalaxy_Colonizer.Models.Enums.PlanetTypes;

namespace RNGalaxy_Colonizer.Models.CelestialBodies.Planets;

public class GiantPlanet : Planet {
    private GiantPlanetType GiantPlanetType { get; }
    private string GiantTypeName => GetGiantTypeName(this.GiantPlanetType);
    
    public GiantPlanet(GiantPlanetType giantPlanetType, string name) : base(name) {
        this.GiantPlanetType = giantPlanetType;
        this.Name = name;
        this.Type = this.GiantTypeName;
    }

    private static string GetGiantTypeName(GiantPlanetType giantPlanetType) {
        var planetTypeName = giantPlanetType switch {
            GiantPlanetType.BrownDwarf => "Brown Dwarf",
            GiantPlanetType.ChtonianPlanet => "Chtonian",
            GiantPlanetType.EccentricJupiter => "Eccentric Jupiter",
            GiantPlanetType.GasGiant => "Gas Giant",
            GiantPlanetType.HeliumPlanet => "Helium",
            GiantPlanetType.HotJupiter => "Hot Jupiter",
            GiantPlanetType.HotNeptune => "Hot Neptune",
            GiantPlanetType.IceGiant => "Ice Giant",
            GiantPlanetType.MiniNeptune => "Mini Neptune",
            GiantPlanetType.PuffyPlanet => "Puffy",
            GiantPlanetType.SuperJupiter => "Super Jupiter",
            _ => ""
        };
        return planetTypeName;
    }
}