using System;
using System.Linq;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4); 

            planetList.Remove("Pluto");

            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }

            // List of Dictionaries with strings and list of strings
            List<Dictionary<string, List<string>>> spacecraft = new List<Dictionary<string, List<string>>>();

            string mariner = "Mariner 10";
            List<string> marinerDestinations = new List<string> {
                "Mercury", "Venus", "Earth"
            };
            Dictionary<string, List<string>> mariner10 = new Dictionary<string, List<string>>();
            mariner10.Add(mariner, marinerDestinations);
            spacecraft.Add(mariner10);

            string sputnik = "Sputnik";
            List<string> sputnikDestinations = new List<string> {
                "Venus", "Pluto"
            };
            Dictionary<string, List<string>> sputnik1 = new Dictionary<string, List<string>>();
            sputnik1.Add(sputnik, sputnikDestinations);
            spacecraft.Add(sputnik1);
        }
    }
}
