using RNGalaxy_Colonizer.Models.Enums.PlanetTypes;

namespace RNGalaxy_Colonizer.Models.CelestialBodies.Planets;

public class GiantPlanet : Planet {
    private GiantPlanetType GiantPlanetType { get; }

    private string PlanetType => this.GiantPlanetType.ToString();

    public GiantPlanet(GiantPlanetType giantPlanetType, string name) : base(name) {
        this.GiantPlanetType = giantPlanetType;
        this.Name = name;
        this.Type = this.PlanetType;
    }
}