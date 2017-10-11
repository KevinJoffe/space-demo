using System;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller>
{
    [Inject] Settings _settings;

    public override void InstallBindings()
    {
        Debug.Log("Binding spawner");
        Container.BindInterfacesTo<PlanetSpawner>().AsSingle();
//        Container.Bind<Vector3>().AsSingle();
        Debug.Log("Binding planets");
        Container.BindFactory<Vector3, Planet, Planet.Factory>().FromComponentInNewPrefab(_settings.PlanetPrefab);
        Debug.Log("Binding sun");
        Container.BindFactory<Sun, Sun.Factory>().FromComponentInNewPrefab(_settings.SunPrefab);
    }

    [Serializable]
    public class Settings
    {
        public GameObject SunPrefab;
        public GameObject PlanetPrefab;
    }
}