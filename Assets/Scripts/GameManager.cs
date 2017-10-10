using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject sun;

    public GameObject[] planets;

    private const int OffsetStep = 15;
    private const int OffsetGap = 10;

    // Use this for initialization
    private void Start()
    {
        Instantiate(sun, sun.transform.position, Quaternion.identity);

        int offset = OffsetStep;

        for (int i = 0; i < planets.Length; i++)
        {
            GameObject planet = planets[i];

            // figure out the position of the planet in 3d space, relative to the position of the sun
            List<Range> ranges = new List<Range>();

            if (i == 0)
            {
                // create a range in a circle
                ranges.Add(new Range(0 - offset, offset));
            }
            else
            {
                // create a range in a donut
                ranges.Add(new Range(-1 * offset - OffsetStep, -1 * offset));
                ranges.Add(new Range(offset - OffsetStep, offset));
            }

            Instantiate(planet, getPlanetPositionRelativeToSun(ranges), Quaternion.identity);

            offset += OffsetStep + OffsetGap;
        }
    }

    private Vector3 getPlanetPositionRelativeToSun(List<Range> ranges)
    {
        float[] xPosition = new float [ranges.Count];
        float[] yPosition = new float [ranges.Count];
        for (int i = 0; i < ranges.Count; i++)
        {
            xPosition[i] = Random.Range(ranges[i].Min, ranges[i].Max);
            yPosition[i] = Random.Range(ranges[i].Min, ranges[i].Max);
        }

        int xIndex = Random.Range(0, ranges.Count);
        int yIndex = Random.Range(0, ranges.Count);

        return new Vector3(sun.transform.position.x + xPosition[xIndex], sun.transform.position.y + yPosition[yIndex],
            sun.transform.position.z);
    }

    private class Range
    {
        private int min;
        private int max;

        public Range(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }
    }
}