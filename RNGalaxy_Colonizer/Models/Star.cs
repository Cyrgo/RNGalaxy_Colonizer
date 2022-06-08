namespace RNGalaxy_Colonizer.Models;

public enum SpectralType {
    // Large Blue Super Giant
    O,

    // Medium Blue Super Giant
    B,

    // Small Blue Super Giant
    A,

    // Yellow Super Giant
    F,

    // Yellow Giant
    G,

    // Orange Giant
    K,

    // Red Giant
    M,

    // White Dwarf
    D
}

public class Star {
    public SpectralType SpectralType { get; }

    public string StarType => GetStarType(this.SpectralType);

    public int Temperature { get; }
    public double Radius { get; }
    public double Mass { get; }
    public double Luminosity { get; }
    public int LifeTime { get; }

    public Star(SpectralType spectralType, int temperature, double radius, double mass, double luminosity, int lifeTime) {
        this.SpectralType = spectralType;
        this.Temperature = temperature;
        this.Radius = radius;
        this.Mass = mass;
        this.Luminosity = luminosity;
        this.LifeTime = lifeTime;
    }

    private static string GetStarType(SpectralType spectralType) {
        var starType = spectralType switch {
            SpectralType.O => "Large Blue Super Giant",
            SpectralType.B => "Medium Blue Super Giant",
            SpectralType.A => "Small Blue Super Giant",
            SpectralType.F => "Yellow Super Giant",
            SpectralType.G => "Yellow Giant",
            SpectralType.K => "Orange Giant",
            SpectralType.M => "Red Giant",
            SpectralType.D => "White Dwarf",
            _ => "Yellow Giant"
        };
        return starType;
    }
}