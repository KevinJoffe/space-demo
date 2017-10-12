using System;
using UnityEngine;
using Zenject;

namespace ZenjectInstallers
{
    public class GameInstaller : MonoInstaller<GameInstaller>
    {
        [Inject] Settings _settings;

        public override void InstallBindings()
        {
            Debug.Log("Binding spawner");
            Container.BindInterfacesTo<PlanetSpawner>().AsSingle();
            Debug.Log("Bind Planet Factory");
            Container.BindFactory<Vector3, Planet, Planet.Factory>().FromComponentInNewPrefab(_settings.PlanetPrefab);
            Debug.Log("Bind Sun Factory");
            Container.BindFactory<Sun, Sun.Factory>().FromComponentInNewPrefab(_settings.SunPrefab);
        }

        [Serializable]
        public class Settings
        {
            public GameObject SunPrefab;
            public GameObject PlanetPrefab;
        }
    }
}