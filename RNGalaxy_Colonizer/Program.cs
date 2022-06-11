using RNGalaxy_Colonizer.Generators;
using RNGalaxy_Colonizer.Models.CelestialBodies;

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
star.Details();

Console.WriteLine("------------------------");

// Planet 1
var planet = PlanetGenerator.Generate();
Console.WriteLine(planet.Name);
Console.WriteLine(planet.Type);