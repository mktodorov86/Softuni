﻿using System.Text;

namespace TestApp;

//описваме всяка една планета
public class Planet
{
    private const double GravitationalConstant = 6.67430e-11; //константа

    //характеристики: име, диаметър, разстояние от слънцето, брой луни
    public string Name { get; set; }

    public double Diameter { get; set; }

    public double DistanceFromSun { get; set; }

    public int NumberOfMoons { get; set; }

    //конструктор
    public Planet(string name, double diameter, double distanceFromSun, int numberOfMoons)
    {
        this.Name = name;
        this.Diameter = diameter;
        this.DistanceFromSun = distanceFromSun;
        this.NumberOfMoons = numberOfMoons;
    }

    //действия

    //1. всяка една планета -> изчислява гравитация
    public double CalculateGravity(double mass)
    {
        double radius = this.Diameter / 2.0;
        return mass * GravitationalConstant / (radius * radius);
    }

    //2. всяка една планета -> получаваме данните за нея под формата на текст
    public string GetPlanetInfo()
    {
        StringBuilder sb = new();

        sb.AppendLine($"Planet: {Name}");
        sb.AppendLine($"Diameter: {Diameter} km");
        sb.AppendLine($"Distance from the Sun: {DistanceFromSun} km");
        sb.AppendLine($"Number of Moons: {NumberOfMoons}");

        return sb.ToString().Trim();
    }
}
