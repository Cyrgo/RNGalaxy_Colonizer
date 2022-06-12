namespace RNGalaxy_Colonizer.Models.CelestialBodies.Planets;

public abstract class Planet {
    protected Enum PlanetType { get; init; }

    public string Name { get; protected init; }
    public string? TypeName { get; protected init; }
    private double Radius { get; set; }
    public int Volume { get; set; }
    public int Mass { get; set; }
    public int Density { get; set; }
    public double Albedo { get; set; }
    public int SurfaceTemperature { get; set; }
    public int OrbitalPeriod { get; set; }
    public double Eccentricity { get; set; }
    public int Inclination { get; set; }
    public Dictionary<string, double>? Composition { get; set; }
    public double Brightness { get; set; }


    protected Planet(Enum planetType, string name) {
        this.PlanetType = planetType;
        this.Name = name;
    }

}