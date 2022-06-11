namespace RNGalaxy_Colonizer.Models.CelestialBodies.Planets;

public abstract class Planet {
    public string Name { get; protected init; }
    public string? Type { get; protected init; }
    protected Planet(string name) {
        this.Name = name;
    }

}