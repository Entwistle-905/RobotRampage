using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using System;
public class Demo : MonoBehaviour
{
    public static void Main()
    {
        Dictionary<string, int> cityPopulation = new Dictionary<string, int>();
        cityPopulation.Add("Tokyo", 38000000);
        cityPopulation.Add("Dehli", 25700000);
        cityPopulation.Add("Shanghai", 23700000);
        cityPopulation.Add("San Paulo", 21000000);
        cityPopulation.Add("Mexico City", 21000000);

        Console.WriteLine("City Population");

        foreach (KeyValuePair<string, int> city in cityPopulation)
        {
            Console.WriteLine("City: " + city.Key + ", Population: " + city.Value);
        }

        Console.WriteLine("Total number of cities: " + cityPopulation.Count);
    }
}
