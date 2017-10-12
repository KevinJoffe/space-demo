using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlanetSpawner : IInitializable
{
    readonly Planet.Factory _planetFactory;
    readonly Sun.Factory _sunFactory;
    private readonly List<Planet> _planets;
    private Sun _sun;

    private readonly int _numPlanets = 20;

    public PlanetSpawner(Planet.Factory planetFactory, Sun.Factory sunFactory)
    {
        _planetFactory = planetFactory;
        _sunFactory = sunFactory;
        _planets = new List<Planet>();
    }

    public void Initialize()
    {
        Debug.Log("PlanetSpawnerInit");
        for (int i = 0; i < 20; i++)
        {
            if (i == 0)
            {
                _sun = _sunFactory.Create();
                _planets.Add(_planetFactory.Create(_sun.transform.position));
            }
            else
            {
                _planets.Add(_planetFactory.Create(_sun.transform.position));
            }
        }
    }
}