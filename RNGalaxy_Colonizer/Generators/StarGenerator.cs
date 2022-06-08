using RNGalaxy_Colonizer.Models;

namespace RNGalaxy_Colonizer.Generators;

public static class StarGenerator {
    public static SpectralType GenerateSpectralType() {
        var spectralTypes = new List<SpectralType> {
            SpectralType.O, SpectralType.B, SpectralType.A, SpectralType.F,
            SpectralType.G, SpectralType.K, SpectralType.M, SpectralType.D
        };
        var random = new Random();
        var randSpectralTypeIndex = random.Next(spectralTypes.Count);
        var randSpectralType = spectralTypes[randSpectralTypeIndex];
        return randSpectralType;
    }

    public static int GenerateTemperature(SpectralType spectralType) {
        var random = new Random();
        var temp = spectralType switch {
            SpectralType.O => random.Next(20001, 40000),
            SpectralType.B => random.Next(8501, 20000),
            SpectralType.A => random.Next(6501, 8500),
            SpectralType.F => random.Next(5701, 6500),
            SpectralType.G => random.Next(4501, 5700),
            SpectralType.K => random.Next(3201, 4500),
            SpectralType.M => random.Next(3000, 3200),
            SpectralType.D => random.Next(3000, 80000),
            _ => random.Next(3000, 3200)
        };
        return temp;
    }

    public static double GenerateRadius(SpectralType spectralType) {
        var radius = spectralType switch {
            SpectralType.O => GeneratorUtils.RandomDouble(5.01, 10.0),
            SpectralType.B => GeneratorUtils.RandomDouble(1.71, 5.0),
            SpectralType.A => GeneratorUtils.RandomDouble(1.31, 1.7),
            SpectralType.F => GeneratorUtils.RandomDouble(1.01, 1.3),
            SpectralType.G => GeneratorUtils.RandomDouble(0.9, 1.0),
            SpectralType.K => GeneratorUtils.RandomDouble(0.31, 0.8),
            SpectralType.M => GeneratorUtils.RandomDouble(0.02, 0.3),
            SpectralType.D => GeneratorUtils.RandomDouble(0.009, 0.01),
            _ => GeneratorUtils.RandomDouble(0.02, 0.3)
        };
        return radius;
    }

    public static double GenerateMass(SpectralType spectralType) {
        var mass = spectralType switch {
            SpectralType.O => GeneratorUtils.RandomDouble(11.0, 50.0),
            SpectralType.B => GeneratorUtils.RandomDouble(2.1, 10.0),
            SpectralType.A => GeneratorUtils.RandomDouble(1.6, 2.0),
            SpectralType.F => GeneratorUtils.RandomDouble(1.1, 1.5),
            SpectralType.G => GeneratorUtils.RandomDouble(0.8, 1.0),
            SpectralType.K => GeneratorUtils.RandomDouble(0.3, 0.7),
            SpectralType.M => GeneratorUtils.RandomDouble(0.02, 0.2),
            SpectralType.D => GeneratorUtils.RandomDouble(0.009, 0.01),
            _ => GeneratorUtils.RandomDouble(0.02, 0.2)
        };
        return mass;
    }

    public static double GenerateLuminosity(SpectralType spectralType) {
        var luminosity = spectralType switch {
            SpectralType.O => GeneratorUtils.RandomDouble(1001.0, 100000.0),
            SpectralType.B => GeneratorUtils.RandomDouble(21.0, 1000.0),
            SpectralType.A => GeneratorUtils.RandomDouble(5.0, 20.0),
            SpectralType.F => GeneratorUtils.RandomDouble(1.1, 4.0),
            SpectralType.G => GeneratorUtils.RandomDouble(0.3, 1.0),
            SpectralType.K => GeneratorUtils.RandomDouble(0.02, 0.2),
            SpectralType.M => GeneratorUtils.RandomDouble(0.006, 0.01),
            SpectralType.D => GeneratorUtils.RandomDouble(0.0009, 0.005),
            _ => GeneratorUtils.RandomDouble(0.006, 0.01)
        };
        return luminosity;
    }

    public static int GenerateLifeTime(SpectralType spectralType) {
        var random = new Random();
        var lifeTime = spectralType switch {
            SpectralType.O => random.Next(10, 99),
            SpectralType.B => random.Next(100, 999),
            SpectralType.A => random.Next(1000, 2999),
            SpectralType.F => random.Next(3000, 9999),
            SpectralType.G => random.Next(1000, 49999),
            SpectralType.K => random.Next(50000, 199999),
            SpectralType.M => 200000,
            SpectralType.D => 0,
            _ => 200000
        };
        return lifeTime;
    }
}