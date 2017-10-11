using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlanetSpawner _planetSpawner;

    private void Start()
    {
        _planetSpawner = new PlanetSpawner(new Planet.Factory(), new Sun.Factory());
    }
}