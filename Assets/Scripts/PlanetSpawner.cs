using UnityEngine;
using Zenject;

public class PlanetSpawner : ITickable
{
    readonly Planet.Factory _planetFactory;
    readonly Sun.Factory _sunFactory;

    public PlanetSpawner(Planet.Factory planetFactory, Sun.Factory sunFactory)
    {
        Debug.Log("PlanetSpawnerConstructor");
        _planetFactory = planetFactory;
        _sunFactory = sunFactory;
    }

    public void Tick()
    {
        Debug.Log("Tick");
        var sun = _sunFactory.Create();
        _planetFactory.Create(sun.transform.position);
    }
}