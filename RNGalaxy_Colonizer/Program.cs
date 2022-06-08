using System.Globalization;
using RNGalaxy_Colonizer.Generators;
using RNGalaxy_Colonizer.Models;

// Star 1
var spectralType = StarGenerator.GenerateSpectralType();
var star = new Star(
    spectralType,
    StarGenerator.GenerateTemperature(spectralType),
    StarGenerator.GenerateRadius(spectralType),
    StarGenerator.GenerateMass(spectralType),
    StarGenerator.GenerateLuminosity(spectralType),
    StarGenerator.GenerateLifeTime(spectralType)
);

Console.WriteLine("Spectral Type: " + star.SpectralType);
Console.WriteLine("Star Type: " + star.StarType);
Console.WriteLine("Temperature: " + star.Temperature + "K");
Console.WriteLine("Radius: " + star.Radius.ToString(CultureInfo.CurrentCulture) + " times Earth's Sun");
Console.WriteLine("Mass: " + star.Mass.ToString(CultureInfo.CurrentCulture) + " times Earth's Sun");
Console.WriteLine("Luminosity: " + star.Luminosity.ToString(CultureInfo.CurrentCulture) + " times Earth's Sun");
Console.WriteLine("Lifetime: " + star.LifeTime + " Million Years");