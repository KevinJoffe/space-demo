using UnityEngine;
using Zenject;

public class Planet : MonoBehaviour
{
    // used for highlighting a planet
    public Behaviour halo;

    [Inject]
    public void Construct(Vector3 position)
    {
        transform.position = getPlanetPosition(position);
        halo.enabled = false;
    }

    public class Factory : Factory<Vector3, Planet>
    {
    }

    private Vector3 getPlanetPosition(Vector3 relativePosition)
    {
        float x = Random.Range(-150, 150);
        float y = Random.Range(-150, 150);
        float z = Random.Range(-200, 50);

        return new Vector3(relativePosition.x + x, relativePosition.y + y, relativePosition.z + z);
    }

    public void OnMouseEnter()
    {
        halo.enabled = true;
    }

    private void OnMouseExit()
    {
        halo.enabled = false;
    }
}