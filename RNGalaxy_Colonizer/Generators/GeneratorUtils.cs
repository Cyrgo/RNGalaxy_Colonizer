namespace RNGalaxy_Colonizer.Generators;

public static class GeneratorUtils {
    public static double RandomDouble(double min, double max) {
        var random = new Random();
        return random.NextDouble() * (max - min) + min;
    }
}