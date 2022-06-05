using RNGalaxy_Colonizer.Models;

namespace RNGalaxy_Colonizer.Generators;

public class StarGenerator {
    public string GenerateSpectralType() {
        var spectralTypes = new List<string> { "O", "B", "A", "F", "G", "K", "M", "D" };
        var random = new Random();
        var randSpectralTypeIndex = random.Next(spectralTypes.Count);
        var randSpectralType = spectralTypes[randSpectralTypeIndex];
        return randSpectralType;
    }

    public int GenerateTemperature(string spectralType) {
        var random = new Random();
        var temp = spectralType switch {
            "O" => random.Next(20001, 40000),
            "B" => random.Next(8501, 20000),
            "A" => random.Next(6501, 8500),
            "F" => random.Next(5701, 6500),
            "G" => random.Next(4501, 5700),
            "K" => random.Next(3201, 4500),
            "M" => random.Next(3000, 3200),
            "D" => random.Next(3000, 80000),
            _ => random.Next(4501, 5700)
        };
        return temp;
    }
    
    public double GenerateRadius(string spectralType) {
        var random = new Random();
        var temp = spectralType switch {
            "O" => random.NextDouble() * (10.0 - 5.01) + 5.01,
            "B" => random.NextDouble() * (5.0 - 1.71) + 1.71,
            "A" => random.NextDouble() * (1.7 - 1.31) + 1.31,
            "F" => random.NextDouble() * (1.3 - 1.01) + 1.01,
            "G" => random.NextDouble() * (1.0 - 0.9) + 0.9,
            "K" => random.NextDouble() * (0.8 - 0.31) + 0.31,
            "M" => random.NextDouble() * (0.3 - 0.02) + 0.02,
            "D" => random.NextDouble() * (0.01 - 0.009) + 0.009,
            _ => 1
        };
        return temp;
    }
}