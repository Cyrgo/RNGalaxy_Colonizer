namespace RNGalaxy_Colonizer.Models; 

public class Star {
    public string SpectralType;
    public int Temperature;
    public double Radius;
    public double Mass;
    public double Luminosity;
    public int LifeTime;
    public double Abundance;

    public Star(string spectralType, int temperature, double radius, double mass, double luminosity, int lifeTime, double abundance) {
        this.SpectralType = spectralType;
        this.Temperature = temperature;
        this.Radius = radius;
        this.Mass = mass;
        this.Luminosity = luminosity;
        this.LifeTime = lifeTime;
        this.Abundance = abundance;
    }
}