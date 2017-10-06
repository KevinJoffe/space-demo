using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject sun;

    public GameObject[] planets;

    // Use this for initialization
    private void Start()
    {
        Instantiate(sun, sun.transform.position, Quaternion.identity);

        for (int i = 0; i < planets.Length; i++)
        {
            GameObject planet = planets[i];

            // figure out the position of the planet in 3d space, relative to the position of the sun

            Instantiate(planet, getPlanetPosition(), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    private Vector3 getPlanetPosition()
    {
        float x = Random.Range(-150, 150);
        float y = Random.Range(-150, 150);
        float z = Random.Range(-200, 50);

        return new Vector3(sun.transform.position.x + x, sun.transform.position.y + y, sun.transform.position.z + z);
    }
}