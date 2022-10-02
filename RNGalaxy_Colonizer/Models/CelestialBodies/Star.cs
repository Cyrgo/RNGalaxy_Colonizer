using System.Globalization;
using RNGalaxy_Colonizer.Models.Enums;

namespace RNGalaxy_Colonizer.Models.CelestialBodies;

public class Star {
    private SpectralType SpectralType { get; }
    private string StarTypeName => GetStarTypeName(this.SpectralType);
    private int Temperature { get; }
    private double Radius { get; }
    private double Mass { get; }
    private double Luminosity { get; }
    private int LifeTime { get; }

    public Star(SpectralType spectralType, int temperature, double radius, double mass, double luminosity, int lifeTime) {
        this.SpectralType = spectralType;
        this.Temperature = temperature;
        this.Radius = radius;
        this.Mass = mass;
        this.Luminosity = luminosity;
        this.LifeTime = lifeTime;
    }

    private static string GetStarTypeName(SpectralType spectralType) {
        var starType = spectralType switch {
            SpectralType.O => "Large Blue Super Giant",
            SpectralType.B => "Medium Blue Super Giant",
            SpectralType.A => "Small Blue Super Giant",
            SpectralType.F => "Yellow Super Giant",
            SpectralType.G => "Yellow Giant",
            SpectralType.K => "Orange Giant",
            SpectralType.M => "Red Giant",
            SpectralType.D => "White Dwarf",
            _ => "Red Giant"
        };
        return starType;
    }

    public void Details() {
        Console.WriteLine("Spectral Type: " + this.SpectralType);
        Console.WriteLine("Star Type: " + this.StarTypeName);
        Console.WriteLine("Temperature: " + this.Temperature + "K");
        Console.WriteLine("Radius: " + this.Radius.ToString(CultureInfo.CurrentCulture) + " times Earth's Sun");
        Console.WriteLine("Mass: " + this.Mass.ToString(CultureInfo.CurrentCulture) + " times Earth's Sun");
        Console.WriteLine("Luminosity: " + this.Luminosity.ToString(CultureInfo.CurrentCulture) + " times Earth's Sun");
        Console.WriteLine("Lifetime: " + this.LifeTime + " Million Years");
    }
}