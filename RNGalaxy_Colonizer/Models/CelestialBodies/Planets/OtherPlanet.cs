using RNGalaxy_Colonizer.Models.Enums.PlanetTypes;

namespace RNGalaxy_Colonizer.Models.CelestialBodies.Planets;

public class OtherPlanet : Planet {
    private OtherPlanetType OtherPlanetType { get; }

    private string PlanetType => this.OtherPlanetType.ToString();
    
    public OtherPlanet(OtherPlanetType otherPlanetType, string name) : base(name) {
        this.OtherPlanetType = otherPlanetType;
        this.Name = name;
        this.Type = this.PlanetType;

    }
}