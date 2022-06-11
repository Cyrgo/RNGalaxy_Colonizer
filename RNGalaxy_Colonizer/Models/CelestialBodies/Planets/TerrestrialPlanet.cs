using RNGalaxy_Colonizer.Models.Enums.PlanetTypes;

namespace RNGalaxy_Colonizer.Models.CelestialBodies.Planets;

public class TerrestrialPlanet : Planet {
    private TerrestrialPlanetType TerrestrialPlanetType { get; }

    private string PlanetType => this.TerrestrialPlanetType.ToString();

    public TerrestrialPlanet(TerrestrialPlanetType terrestrialPlanetType, string name) : base(name) {
        this.TerrestrialPlanetType = terrestrialPlanetType;
        this.Name = name;
        this.Type = this.PlanetType;
    }
}