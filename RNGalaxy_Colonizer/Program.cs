using RNGalaxy_Colonizer.Generators;

// Star 1
var star = StarGenerator.Generate();
star.Details();

Console.WriteLine("------------------------");

// Planet 1
var planet = PlanetGenerator.Generate();
Console.WriteLine(planet.Name);
Console.WriteLine(planet.TypeName);