using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlanetSpawner : ITickable
{
    readonly Planet.Factory _planetFactory;
    readonly Sun.Factory _sunFactory;
    private List<Planet> planets;
    private Sun sun;

    public PlanetSpawner(Planet.Factory planetFactory, Sun.Factory sunFactory)
    {
        Debug.Log("PlanetSpawnerConstructor");
        _planetFactory = planetFactory;
        _sunFactory = sunFactory;
        planets = new List<Planet>();
    }

    public void Tick()
    {
        Debug.Log("Tick");

        if (planets.Count == 0)
        {
            sun = _sunFactory.Create();
            planets.Add(_planetFactory.Create(sun.transform.position));
        }
        else if (planets.Count < 100)
        {
            planets.Add(_planetFactory.Create(sun.transform.position));
        }
    }
}